using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
//program is to count character from string and print unique char from string

            string str;
            Console.WriteLine("enter stirng : ");
            str = Console.ReadLine();
            int[] ar = new int[256];
            for (int i = 0; i < 256; i++) ar[i] = 0;

            
            foreach(char ch in str)
            {
                int pos = (int)ch;
                ar[pos]++;
            }
            string s = "";
            for(int i = 0; i < 256; i++)
            {
                if (ar[i] >= 1)
                {
                    char c = (char)i;
                    s += c;
                }
            }

            Console.WriteLine("Unique char is : " + s);
            int len = s.Length;
            for(int i=0;i< len; i++)
            {
                int pos = (int)s[i];
                Console.WriteLine("char is : " + s[i] + " frequecncy : " + ar[pos]);
            }

        }
    }
}
