using System;
using System.ComponentModel;

namespace ExofAbstractMethod
{

//parent class (abstract class)
abstract class Person
{
    public string PersonName;
    public string Gender;

    //abstract method in parent class. Abstract method doesn't contain method body. It contains only method signature.
    public abstract void Display();
}
//child class 1
class Student : Person
{
    public int StudentID;
    public int Marks;

    //Student.Display
    //Method Overriding: This method overrides the parent class's abstract method called "Display". Both methods are having the same signature.
    public override void Display()
    {
        //base keyword is calling the method of based class
        System.Console.WriteLine("Student Name: " + base.PersonName);
        System.Console.WriteLine("Gender: " + base.Gender); 
        System.Console.WriteLine("Student ID: " + this.StudentID);
        System.Console.WriteLine("Student Marks: " + this.Marks);
    }
}
//child class 2
class Employee : Person
{
    public int EmpID;
    public double Salary;

    //Employee.Display
    //Method overriding: This method overrides the parent class's abstract method called "Display". Both methods are having the same signature.
    public override void Display()
    {
        System.Console.WriteLine("Employee Name: " + base.PersonName); 
        System.Console.WriteLine("Gender: " + base.Gender);
        //which represents “current object”, based on which, the method or constructor was called.
        System.Console.WriteLine("Employee ID: " + this.EmpID); 
        System.Console.WriteLine("Employee Salary: " + this.Salary);
    }
}



class Program
    {
        static void Main(string[] args)
        {
        /*********** creating object for child class 1 *****************/
        Student s;
        s = new Student(); 
        s.PersonName = "Allen";
        s.Gender = "Male";
        s.StudentID = 101;
        s.Marks = 70; s.Display();
        System.Console.WriteLine("\n");


        /*********** creating object for child class 2 *****************/
        Employee emp;
        emp = new Employee(); 
        emp.PersonName = "Jones";
        emp.Gender = "Male";
        emp.EmpID = 201;
        emp.Salary = 7000;
        emp.Display();

        System.Console.ReadKey();

    }
}
}
