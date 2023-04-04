using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//here we will impletment getinumerable 

namespace IEnumerable_getInumerable
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }
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



     class Program
    {
        static void Main(string[] args)
        {
            //create some student object
            Student st1 = new Student();
            st1.id = 1;
            st1.name = "Miza";
            st1.standard = 1;

            Student st2 = new Student();
            st2.id = 2;
            st2.name = "aiza";
            st2.standard = 1;

            Student st3 = new Student();
            st3.id = 3;
            st3.name = "aiza";
            st3.standard = 2;

            Student st4 = new Student();
            st4.id = 4;
            st4.name = "aada";
            st4.standard = 2;

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
