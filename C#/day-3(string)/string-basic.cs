using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_basci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello Mizan";
            Console.WriteLine(str);

            char[] ch = { 'a', 'b', 'c', 'e' };
            Console.WriteLine(ch);

            //create stirng from char array
            string s = new string(ch);
            Console.WriteLine("string from ar : "+ s);

            //user input as string
            Console.WriteLine("enter a line : ");
            string given = Console.ReadLine();
            Console.WriteLine("given string is : " + given);

     //lenght of string : str.Length;
            int len = str.Length;
            Console.WriteLine("stirng length : " + len);

            //join two stirng
            string s1 = "Mizan", s2 = "Rahman";
            string s3 = s1 +" "+ s2;
            Console.WriteLine(s3);


            //substring(startIndex, len);
            string s4 = s3.Substring(1, 4);
            Console.WriteLine("substring is : "+s4);



            //toupper 
            s4 = s4.ToUpper();
            Console.WriteLine(s4);
            //tolower 
            s4 = s4.ToLower();
            Console.WriteLine(s4);

            //index of char from stirng
            int pos = str.IndexOf('i');
            Console.WriteLine("Index of i : " + pos);




            //string interpolation : add stirng as keyword
            string name = "Mizan";

            string demo = $"hello mr {name}";

            Console.WriteLine("interpolated line : " + demo);






        }
    }
}
