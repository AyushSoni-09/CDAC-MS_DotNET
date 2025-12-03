namespace JaggeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged array is array of arrays
            //That means it is an array fundamentally.And in each row you will have another array.
            //But the difference between the multidimensional and jagged array is that in case of multidimensional,
            //the number of columns for all the rows must be the same.
            //But in case of jagged arrays, the number of columns.That means the number of values for each row can be different.

            //create jagged array
            int[][] a = new int[5][];
            a[0]=new int[3] { 10,20,30};
            a[1] = new int[5] { 40, 50, 60, 70, 80 };
            a[2] = new int[2] { 90, 100 };
            a[3] = new int[4] { 12, 46, 55, 23 };
            a[4] = new int[8] { 56, 45, 13, 8, 2, 5, 33, 58 };


            //reading jagged array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }
}
