using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_4
{
    class Program
    {
        public void Run()
        {
            ProgramConverter[] myConverters = new ProgramConverter[4];
            string source = "I am some kind of source being";
            for (int i = 0; i < 4; i++)
            {
                if (i%2 == 0)
                {
                    myConverters[i] = new ProgramConverter();
                }
                else
                {
                    myConverters[i] = new ProgramHelper();
                }
            }

            foreach (ProgramConverter convert in myConverters)
            {
                ICodeChecker myCodeChecker = convert as ICodeChecker;
                if (myCodeChecker != null)
                {
                    Console.WriteLine("I Implement ICodeChecker.");
                }
                else
                {
                    Console.WriteLine("Not me");
                }
            }
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();

            Console.ReadKey();
        }
    }
}
