using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_3
{
    class Program
    {
       
            public void Run()
        {
            ProgramHelper myHelper = new ProgramHelper();
            string source = "I am some kind of source being";
            Console.WriteLine(myHelper.ConvertToCSharp(source));
            Console.WriteLine(myHelper.ConvertToVB(source));
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();

            Console.ReadLine();
        }
        
    }
}
