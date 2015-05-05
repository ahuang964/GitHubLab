using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise15_4
{
    class Program
    {
        public void Run()
        {
            string famousString = "We hold these truths to be self-evident, that all men are created equal, that they are endowed by their Creator with certain unalienable Rights, that among these are Life, Liberty and the pursuit of Happiness.";
            Regex theRegex = new Regex(" |, ");
            StringBuilder sBuilder = new StringBuilder();
            int lineNumber = 1;

            foreach (string subString in theRegex.Split(famousString))
            {
                Console.WriteLine("{0} {1}", lineNumber, subString);
                lineNumber++;
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
