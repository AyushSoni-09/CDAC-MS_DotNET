namespace ExofHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a HashSet of strings
            HashSet<string> names = new HashSet<string>();

            // Add elements
            names.Add("Deepa");
            names.Add("Roopa");
            names.Add("Krupa");
            names.Add("Shilpa");

            // Attempt to add a duplicate (this will be ignored)
            names.Add("Deepa");

            // Print the elements in the HashSet
            Console.WriteLine("Elements in the HashSet:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Check if an element exists
            if (names.Contains("Roopa"))
            {
                Console.WriteLine("\n'Roopa' is in the set.");
            }

            // Remove an element
            names.Remove("Krupa");

            Console.WriteLine("\nAfter removing Krupa':");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

    }
}

