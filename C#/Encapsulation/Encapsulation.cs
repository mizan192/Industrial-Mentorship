using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
public class Person
{
    private string name;  //data members
    private int age;//data members
    private DateTime createdAt;
    public Person()
    {
        this.createdAt = DateTime.Now;
    }

    public DateTime GetCreationDate()
    {
        return this.createdAt;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetName(string pName)
    {
        this.name = pName;
    }
    public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int pAge)
    {
        if (pAge > 0 && pAge < 150)
        {
            this.age = pAge;
        }
        else
        {
            throw new Exception("Invalid age");
        }
    }


    public void DisplayPersonDetails()  //members
    {
        Console.WriteLine($"name= {name}, age={age}");
    }

}

public class Program
{
    static void Main()
    {
        Person p = new Person();
        p.SetName("mizan");
        p.SetAge(15);
        Console.WriteLine($"Created at : {p.GetCreationDate()}");
        p.DisplayPersonDetails();
    }
}
}
