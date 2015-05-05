using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15_1
{
    class Program
    {
        public void Run()
        {
            string str1 = "Hello ";
            string str2 = "World";
            string str3 = "Come visit us at http://www.LibertyAssociates.com";
            string str4 = string.Concat(str1, str2);
            string str5 = "world";
            string str6 = string.Copy(str3);
            
            //Output the length of each string.
            Console.WriteLine("Length of String 1 : {0}", str1.Length);
            Console.WriteLine("Length of String 2 : {0}", str2.Length);
            Console.WriteLine("Length of String 3 : {0}", str3.Length);
            Console.WriteLine("Length of String 4 : {0}", str4.Length);
            Console.WriteLine("Length of String 5 : {0}", str5.Length);
            Console.WriteLine("Length of String 6 : {0}", str6.Length);
            //Output the third character in each string.
            Console.WriteLine("Third Char of String 1 : {0}", str1[2]);
            Console.WriteLine("Third Char of String 2 : {0}", str2[2]);
            Console.WriteLine("Third Char of String 3 : {0}", str3[2]);
            Console.WriteLine("Third Char of String 4 : {0}", str4[2]);
            Console.WriteLine("Third Char of String 5 : {0}", str5[2]);
            Console.WriteLine("Third Char of String 6 : {0}", str6[2]);
            //Output whether the character H appears in each string.
            Console.WriteLine("Does H appears in String1 ? {0}", str1.Contains('H'));
            Console.WriteLine("Does H appears in String2 ? {0}", str2.Contains('H'));
            Console.WriteLine("Does H appears in String3 ? {0}", str3.Contains('H'));
            Console.WriteLine("Does H appears in String4 ? {0}", str4.Contains('H'));
            Console.WriteLine("Does H appears in String5 ? {0}", str5.Contains('H'));
            Console.WriteLine("Does H appears in String6 ? {0}", str6.Contains('H'));
            //Output which strings are the same as string 2.
            Console.WriteLine("Str1 == Str2? {0}", str1 == str2);
            Console.WriteLine("Str3 == Str2? {0}", str3 == str2);
            Console.WriteLine("Str4 == Str2? {0}", str4 == str2);
            Console.WriteLine("Str5 == Str2? {0}", str5 == str2);
            Console.WriteLine("Str6 == Str2? {0}", str6 == str2);
            //Output which strings are the same as string 2, ignoring case.
            Console.WriteLine("Str1 == Str2? {0}", string.Compare(str1,str2,true));
            Console.WriteLine("Str3 == Str2? {0}", string.Compare(str3, str2, true));
            Console.WriteLine("Str4 == Str2? {0}", string.Compare(str4, str2, true));
            Console.WriteLine("Str5 == Str2? {0}", string.Compare(str5, str2, true));
            Console.WriteLine("Str6 == Str2? {0}", string.Compare(str6, str2, true));
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            test.Run();
            Console.ReadKey();
        }
    }
}
