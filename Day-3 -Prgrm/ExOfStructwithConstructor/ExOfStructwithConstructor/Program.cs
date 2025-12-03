namespace ExOfStructwithConstructor
{
    //C# provides a parameter-less constructor for every
    //structure by default
    //you can also create one or more user-defined parameterized
    //constructor in structure
    //Each parameterized constructor must initialize all fields;otherwise it will be compile-time error
    //The "new" keyword used with structure,doesnt create
    //doesnt create any object/allocate any memory
    //memory in heap;it is a just a syntax to call constructor of structure.

    internal class Program
    {
        static void Main(string[] args)
        {
            //create structure instance
           // Category category = new Category();

            Category   category = new Category(20,"Finance");
            
            //initialize fields through properties
          //  category.CategoryID = 20;
           // category.CategoryName = "General";


            //access methods
            Console.WriteLine(category.CategoryID);
            Console.WriteLine(category.CategoryName);
            Console.WriteLine(category.GetCategoryNameLength());
            Console.ReadKey();

        }
    }
}
