namespace ExOfReverse
{
     class Program
    {
        static void Main(string[] args)
        {
            List<double> mylist = new List<double>() { 10,56,777,86,991,863,12,77};
            //sort array
            mylist.Sort();

            //reverse array
            mylist.Reverse();
            foreach (double d in mylist)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
