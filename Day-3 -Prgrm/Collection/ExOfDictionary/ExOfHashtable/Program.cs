using System.Collections;

namespace ExOfHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an hashtable
            Hashtable employees = new Hashtable()
            {
                {101,"Scott"},
                {105,"James"},
                {102,"Allen"},
                {103,"Smith" },
                { 104,"Jones"},
                {"hello",10.934 }
            };

            employees.Add(106, "Anna");

            //remove element
            employees.Remove(103);

            foreach (var item in employees)
            {
              
                    Console.WriteLine(item);
            

            }
            Console.ReadKey();
        }
    }
}
