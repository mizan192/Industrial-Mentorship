using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring
{
    internal class Program
    {
//substring check, s2 is substirng of s1 or not
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("enter two string : ");
            s1= Console.ReadLine();
            s2 = Console.ReadLine();
            int l1 = s1.Length;
            int l2 = s2.Length;
            if (l2 > l1)
            {
                Console.WriteLine("s2 is not substirng of s1");
            }
            else
            {
                for(int i = 0; i+l2<=l1; i++)
                {
                    string str = s1.Substring(i, l2);
                    //Console.WriteLine(str);
                    if (str == s2)
                    {
                        Console.WriteLine("s2 is substirng of s1");
                        return;
                    }
                }
                Console.WriteLine("s2 is not substirng of s1");
            }
        }
    }
}
