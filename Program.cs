using System;

namespace sample_programming_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product query engine:");
            ProductTest.Run();

            Console.WriteLine("Given a string find out duplicate character and its count");
            new DuplicatesInString().Run();
        }
    }
}
