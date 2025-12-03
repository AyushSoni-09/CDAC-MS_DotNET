namespace ExOfDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an empy dictoinary
            Dictionary<int,string> employees = new Dictionary<int,string>()
            {
                {101,"Scott"},
                {102,"Allen"},
                {103,"Smith" }
            };
            //foreach loop for dictionary
            foreach (KeyValuePair<int,string> item in employees)
            {
                Console.WriteLine(item.Key+ "," + item.Value); 
            }

            //get value based on the key
            string s = employees[101];
            Console.WriteLine("\nValue at 101:" + s);

            //Keys
            Dictionary<int, string>.KeyCollection keys = employees.Keys;
            Console.WriteLine("\nKeys:");
            foreach(int item in keys)
            {
                Console.WriteLine(item); 

            }
            Console.ReadLine();

            //value
            Dictionary<int, string>.ValueCollection val = employees.Values;
            Console.WriteLine("\nValues:");
            foreach (string item in val)
            {
                Console.WriteLine(item);

            }
        }
    }
}
