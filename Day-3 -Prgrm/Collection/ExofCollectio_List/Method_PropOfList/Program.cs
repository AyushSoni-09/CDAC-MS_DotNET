namespace Method_PropOfList
{
   class Program
    {
        static void Main(string[] args)
        {
            //create reference variable for list class & create object of list class
            List<int> Mylist = new List<int>(10) { 10,20,30};


            //add new element at the end of existing collection
            Mylist.Add(90);
            Mylist.Insert(3, 88);

            //read elements usign foreach loop
            Console.WriteLine("Using foreach loop");
            foreach (int item in Mylist)
            { 
                Console.WriteLine(item);
            }
                Console.ReadKey();

            //create another list collection called "extra"
            List<int> extra = new List<int>() { 300, 400, 500 };

            //add all the elements of "extra" collection at the end of "a" collection

            Mylist.AddRange(extra);

            //get values from list collection
            foreach (int item in Mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
