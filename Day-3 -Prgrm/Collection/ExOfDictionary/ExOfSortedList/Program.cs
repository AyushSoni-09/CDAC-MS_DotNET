namespace ExOfSortedList
{
    internal class Program
    {
        //SortedList collection contains a group of elements
        //of key/value pairs
        //Full Path:system.Collections.Generic.SortedList
        static void Main(string[] args)
        {
            //create an sortedlist
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101,"Scott"},
                {105,"James"},
                {102,"Allen"},
                {103,"Smith" },
                { 104,"Jones"}
            };

            //add element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach 
            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }

            //get value based on key
            string eName = employees[105];
            Console.WriteLine("\nEmployees name a 105:" +eName);

            Console.ReadKey();
        }
    }
}
