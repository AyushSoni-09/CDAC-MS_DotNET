namespace ExOfMutliDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mutildimension array 4*3
            int[,] a = new int[4, 3]
            {
                {10,20,30},
                {40,60,70},
                {80,45,35},
                {95,65,85}
             };
            //read data from muti dimension
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
