namespace ExOfStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create structure instance
            Category category = new Category();
            
            //initialize fields through properties
            category.CategoryID = 20;
            category.CategoryName = "General";

            //access methods
            Console.WriteLine(category.CategoryID);
            Console.WriteLine(category.CategoryName);
            Console.WriteLine(category.GetCategoryNameLength());
            Console.ReadKey();

        }
    }
}
