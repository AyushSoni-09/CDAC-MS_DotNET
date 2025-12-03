using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ExOfArrayList
{
    class Sample
    {
        public int GetNumber()
        { return 10; }
        public double GetAnotherNumber()
        {
            return 10.8;
        }

        public string GetMessage()
        {
            return "Hello!! Every one";
        }

        public Employee GetEmployee()
        {
            return new Employee() { EmployeeName = "Scott" };
        }
    
    }
    class Employee
    {

        public required string EmployeeName {get;set;}
    }
     class Program
    {
        static void Main(string[] args)
        {
            //create object of ArrayList class
            ArrayList arrayList = new ArrayList() {100,'A' };

            Sample s = new Sample();
            //add
            arrayList.Add(s.GetNumber());
            arrayList.Add(s.GetAnotherNumber());
            arrayList.Add(s.GetMessage());  
            arrayList.Add(s.GetEmployee());
            
            //foreach
            foreach(var item in arrayList)
            {
                if (item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }

                }
           // Console.ReadKey();
           
            //example of Queue
            /*Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");
            arrayList.AddRange(myQ);
            
            Console.WriteLine("ArrayList Elements");

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);
            */
        }
    }
}
