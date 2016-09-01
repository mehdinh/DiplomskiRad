using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    public class Container : IContainer
    {        
        private IDictionary<Type, TypeRegistration> typeRegistrations = new Dictionary<Type, TypeRegistration>();
        private IDictionary<string, NamedTypeRegistration> namedTypeRegistrations = new Dictionary<string, NamedTypeRegistration>();

        private IDictionary<Type, object> singletons = new Dictionary<Type, object>();
        private IDictionary<string, object> namedSingletons = new Dictionary<string, object>();

        public void Register<TContract, TImplementation>(Lifetime lifetime = Lifetime.Transient)
        {
            if (typeRegistrations.ContainsKey(typeof(TContract)))
            {
                throw new ContainerException("Contract was already registered with the container.");
            }

            if (!typeof(TContract).IsInterface)
            {
                throw new ContainerException("Contract must be an interface.");
            }

            if (!typeof(TImplementation).IsClass || typeof(TImplementation).IsAbstract)
            {
                throw new ContainerException("Implementation must be a class and it must not be abstract.");
            }

            var typeRegistration = new TypeRegistration()
            {
                ContractType = typeof(TContract),
                ImplementationType = typeof(TImplementation),
                Lifetime = lifetime
            };

            typeRegistrations.Add(typeof(TContract), typeRegistration);
        }

        public void Register<TContract, TImplementation>(string name, Lifetime lifetime = Lifetime.Transient)
        {
            if (namedTypeRegistrations.ContainsKey(name))
            {
                throw new ContainerException("Named contract was already registered with the container.");
            }

            if (!typeof(TContract).IsInterface)
            {
                throw new ContainerException("Contract must be an interface.");
            }

            if (!typeof(TImplementation).IsClass || typeof(TImplementation).IsAbstract)
            {
                throw new ContainerException("Implementation must be a class and it must not be abstract.");
            }

            var namedTypeRegistration = new NamedTypeRegistration()
            {
                Name = name,
                ContractType = typeof(TContract),
                ImplementationType = typeof(TImplementation),
                Lifetime = lifetime
            };

            namedTypeRegistrations.Add(name, namedTypeRegistration);
        }

        public T Resolve<T>()
        {
            var type = typeof(T);
            if (type.IsInterface && !typeRegistrations.ContainsKey(type))
            {
                throw new Exception("Contract was not registered with the container.");
            }

            if (type.IsInterface)
            {
                var typeRegistration = typeRegistrations[type];
                if (typeRegistration.Lifetime == Lifetime.Transient)
                {
                    return (T)Activator.CreateInstance(typeRegistration.ImplementationType);
                }
                else if (singletons.ContainsKey(type))
                {
                    return (T)singletons[type];              
                }
                else
                {
                    var implementation = (T)Activator.CreateInstance(typeRegistration.ImplementationType);
                    singletons.Add(type, implementation);
                    return implementation;
                }
            }
            else if (type.IsClass && !type.IsAbstract)
            {
                var constructors = type.GetConstructors();
                if (constructors.Count() != 1)
                {
                    throw new ContainerException("Only one constructor is supported per class.");
                }

                var constructor = constructors.FirstOrDefault();
                var parameters = constructor.GetParameters();
                var arguments = new List<object>();
                foreach(var parameter in parameters)
                {
                    MethodInfo method = typeof(Container).GetMethod("Resolve", new Type[] { });
                    MethodInfo genericMethod = method.MakeGenericMethod(parameter.ParameterType);
                    var argument = genericMethod.Invoke(this, null);
                    arguments.Add(argument);
                }
                return (T)Activator.CreateInstance(type, arguments.ToArray());                
            }

            throw new ContainerException("Unable to resolve requested contract.");
        }

        public T Resolve<T>(string name)
        {
            if (!namedTypeRegistrations.ContainsKey(name))
            {
                throw new Exception("Named contract was not registered with the container.");
            }

            var namedTypeRegistration = namedTypeRegistrations[name];
            if (typeof(T) != namedTypeRegistration.ContractType)
            {
                throw new Exception("Named contract is not of correct type.");
            }

            if (namedTypeRegistration.Lifetime == Lifetime.Transient)
            {
                return (T)Activator.CreateInstance(namedTypeRegistration.ImplementationType);
            }
            else if (namedSingletons.ContainsKey(name))
            {
                return (T)namedSingletons[name];
            }
            else
            {
                var implementation = (T)Activator.CreateInstance(namedTypeRegistration.ImplementationType);
                namedSingletons.Add(name, implementation);
                return implementation;
            }

            throw new ContainerException("Unable to resolve requested contract.");
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            var implementationList = new List<T>();
            foreach (var name in namedTypeRegistrations.Keys)
            {
                var namedTypeRegistration = namedTypeRegistrations[name];
                if (namedTypeRegistration.ContractType == typeof(T))
                {
                    MethodInfo method = typeof(Container).GetMethod("Resolve", new Type[] { typeof(string) });
                    MethodInfo genericMethod = method.MakeGenericMethod(typeof(T));
                    var implementation = (T)genericMethod.Invoke(this, new object[] { name } );
                    implementationList.Add(implementation);
                }
            }
            return implementationList;
        }
    }
}
