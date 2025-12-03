namespace ExOfSysClassArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array
            double[] a = new double[6] { 10, 20, 30, 40, 50, 50 };

            //search for 30 in the array
            int n = Array.IndexOf(a, 30);
            Console.WriteLine("30 is found at" +n);
            Console.ReadKey();

            //example of Resize();
            //create array
            int[]b = new int[] { 12,15,13};

            //sort ascending order
           // Array.Sort(b);

            //resize array to 5
            Array.Resize(ref b,5);

            

            //print array
            foreach (var item in b)
            { 
                Console.WriteLine(item);
            
            }
            Console.ReadKey();
        }
    }
}
