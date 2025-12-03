namespace ExofCollectio_List
{
    class Program
    {
        //List collection contains a group of elements of same type
        //System.collections.Generic.List
        //The "list" class is generic class,so you  need to specify data type of value while creating object
       static void Main(string[] args)
        {
            List<int> mylist;
            
            mylist = new List<int>() { 56,9,12,45};

            //read elements usig foreach loop
            foreach (int item in mylist) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

           

        }   
    }
}
