using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    class Student
    {
        //private field
        private int age = 21;
        //protected field 
        protected int credit_hour;
        //internal field
        internal int id;
        internal string d_name;
         
        protected void studentProfile()
        {
            Console.WriteLine("Student age : " + age);
            Console.WriteLine("Student id : " + id);
            Console.WriteLine("Student department : " + d_name);
            Console.WriteLine("Student Total_credit : " + credit_hour);
        }
    }

    class Versity : Student
    {
        private int credit_cost=120;
        private int total_cost;
       public Versity(int _id, int _credit, string _name)
        {
            id = _id;
            credit_hour = _credit;
            d_name = _name;
        }

        internal void show_profile()
        {
            studentProfile();
            total_cost = credit_hour * credit_cost;
            Console.WriteLine("Student total credit cost : " + total_cost);
        }


    }



    internal class Inheritance_code
    {
        static void Main(string[] args)
        {
            Versity v1 = new Versity(1, 20, "CSE");
            v1.show_profile();
               
                

        }
    }
}

/*
 we can't call studentprofile() from Inheritance_code class as it protected
 */