namespace ExOfArray_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array with 5 elements
            int[] a = new int[8] { 10, 20, 50, 80, 100,150,200,44 };

            //get values from array, using foreach loop
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}

