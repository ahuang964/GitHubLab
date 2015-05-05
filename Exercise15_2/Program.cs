using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15_2
{
    class Program
    {
        public void Run()
        {
            string famousString = "To be, or not to be: That is the question: Whether ‘tis nobler in the mind to suffer the slings and arrows of outrageous fortune, or to take arms against a sea of troubles, and by opposing end them?";
            int lastSpace = 0;
            string lastWord ;
            StringBuilder reverseFamousString = new StringBuilder();

            while(famousString.Length >= 1)
            {
                lastSpace = famousString.LastIndexOf(" ");
                if (lastSpace == -1)
                {
                    //found last word;
                    lastWord = famousString;
                    famousString = famousString.Substring(0, 0);
                    Console.WriteLine("lastword: " + famousString);
                    Console.WriteLine("famous string: " + famousString); 
                }
                else
                {
                    lastWord = famousString.Substring(lastSpace + 1);
                    famousString = famousString.Substring(0, lastSpace);
                    Console.WriteLine("lastword: " + lastWord);
                    Console.WriteLine("famous string: " + famousString);   
                }
                reverseFamousString.Append(lastWord);
                reverseFamousString.Append(" ");
            }

            Console.WriteLine("Reverse order: {0}", reverseFamousString);
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
