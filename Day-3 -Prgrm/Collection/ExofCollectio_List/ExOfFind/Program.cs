namespace ExOfFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection with marks of student
            List<int> marks = new List<int>() { 40,95,24,70,16,81};

            //exist:check if the student is failed
            bool b = marks.Exists(m => m < 35);

            if (b == true)
            {
                Console.WriteLine("Student is failed in one or more subjects");

            }
            else
            {
                Console.WriteLine("Student is Pass");

            }
                //Find:Get marks of first failed subject
                int firstfailedMarks = marks.Find(m => m < 35);
                Console.WriteLine("First Failed marks :" + firstfailedMarks);
                
                Console.ReadKey();
        
        }

    }
}
