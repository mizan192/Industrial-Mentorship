using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_practise
{

    public class Person
    {
       private int age, salary;
       private bool marid_status;
//this is example of method overridding 
        public virtual void show_profile()
        {
            Console.WriteLine("I am a single person");
            Console.WriteLine("I do nothing");
        }
//this is example of method overloading
        public void show_status(int _age, bool _marrid)
        {
            age = _age;
            marid_status = _marrid;
            Console.WriteLine("My age is : " + age);
            if (marid_status)
                Console.WriteLine("I am Marrid");
            else Console.WriteLine("I am still single");
        }
        public void show_status(int _age, bool _marrid, int _salary)
        {
            age = _age;
            salary = _salary;
            marid_status = _marrid;
            Console.WriteLine("My age is : " + age);
            Console.WriteLine("My salary is : " + salary);
            if (marid_status)
                Console.WriteLine("I am Marrid");
            else Console.WriteLine("I am still single");
        }
    }

    public class Teacher : Person
    {
        public override void show_profile()
        {
            Console.WriteLine("I am a person of Teacher");
            Console.WriteLine("I teach student");
        }
    }

    public class Farmer : Person
    {
        public override void show_profile()
        {
            Console.WriteLine("I am a person of Farmer");
            Console.WriteLine("I work on field");
        }
    }

    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            //our base calss is Person and all of our object will be
            //used as their character
            Person t;
            t = new Teacher();
            t.show_profile();    // method overriding
            t.show_status(12, true);   //method overloading
            t.show_status(13, false, 122);   //method overloading

            Person f;
            f = new Farmer();
            f.show_profile();
            f.show_status(21, false);   //method overloading
            f.show_status(34, true, 232);   //method overloading

        }
    }
}
