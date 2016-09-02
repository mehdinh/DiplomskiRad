using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    class TestClass1
    {
        public void Test()
        {
            // Neispravan kod - ne može se kreirati instanca iz interfejsa
            // ILogger logger = new ILogger();
            
            // Ispravno, instanca se kreira iz klase, ali je tip varijable interfejs ILogger
            // ILogger logger = new ConsoleLogger();

            // Ispravno, instanca se kreira iz klase, ali je tip varijable interfejs ILogger
            // ILogger logger = new TextLogger();

            // Ispravno sa stanovišta programskog jezika, ali neispravno u kontekstu zavisnosti
            // FileLogger logger = new FileLogger();
        }
    }
}
