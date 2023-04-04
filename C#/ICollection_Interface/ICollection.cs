using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ICooletcion same as IEnumerable but Icollection has
//extra method as Add and Remove

namespace ICollection_Interface
{

    class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Student(int id, string name) { 
            Id = id;
            Name = name;
        }
    }


    internal class ICollection
    {
        static void Main(string[] args)
        {
            //create a collection of Student
            ICollection<Student> students = new List<Student>();

            //add student
            students.Add(new Student(1, "abc"));
            students.Add(new Student(2, "aabdc"));
            students.Add(new Student(32, "adfdabc"));
            students.Add(new Student(13, "aadbac"));
            students.Add(new Student(122, "aadbc"));
            students.Add(new Student(21, "adabc"));

            //print student 

            Console.WriteLine("Students are : ");
            foreach(Student s in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}", s.Id, s.Name);
            }


//Remove Student 
    
            students.Remove(new Student(2, "aabdc"));
            students.Remove(new Student(122, "aadbc"));

            Console.WriteLine("Students after removing : ");
            foreach (Student s in students)
            {
                Console.WriteLine("ID: {0}, Name: {1}", s.Id, s.Name);
            }
        }
    }
}
