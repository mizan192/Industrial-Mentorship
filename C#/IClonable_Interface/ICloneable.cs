using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable_Interface
{
    class Student : ICloneable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }

        //this clone method will create a copy of same Stduent data
        //so we don't need to redeclear same type data
        public object Clone()
        {
            return new Student { id = id, name = name, standard = standard };   
        }
    }

    //when a Add method will call then it will store Student class in list
    class School : IEnumerable
    {
        List<Student> students = new List<Student>();
        public void Add(Student s)
        {
            students.Add(s);
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }

    //here

    class Program
    {
        static void Main(string[] args)
        {
            //create some student object
            Student st1 = new Student();
            st1.id = 1;
            st1.name = "Miza";
            st1.standard = 1;

            Student st2 = (Student)st1.Clone();
         

            Student st3 = (Student)st2.Clone();


            Student st4 = (Student)st3.Clone();


            //store all student in list

            School students = new School();

            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);

            //print sutdent data with for lop
            //here we can iterate this because GetIenumerator method return this
            foreach (Student s in students)
            {
                Console.WriteLine(s.id + " " + s.name + " " + s.standard);
            }

        }
    }
}
