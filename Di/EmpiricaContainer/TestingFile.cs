using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpiricaContainer
{
    class TestingFile
    {
        public void Test()
        {
            ILogger logger = new ILogger();
            // Ispravno
            ILogger logger = new ConsoleLogger();
            
            // Ispravno
            ILogger logger = new TextLogger();

            // Neispravno
            TextLogger logger = new TextLogger();

        }
    }
}

public interface ILogger
{
    void Log(string text);
}

public class ConsoleLogger : ILogger
{
    public void Log(string text)
    {
        Console.WriteLine(DateTime.Now.ToString() + " " + text);
    }
}

public class FileLogger : ILogger
{
    public void Log(string text)
    {
        System.IO.File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + text + Environment.NewLine);
    }
}

public class Repository
{
    public Person GetById(int id)
    {
        // Ako želimo koristiti ispi na konzolu koristimo ConsoleLogger
        ILogger logger = new ConsoleLogger();
        
        // Ako želimo koristiti ispis u datoteku koristimo TextLogger
        // ILogger logger = new FileLogger();
        logger.Log("Učitavanje podataka o osobi čiji je ID " + id.ToString());
        throw new NotImplementedException();
    }
}

public class Person
{ }
