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
            new DuplicateCharsInString().Run();

            Console.WriteLine("Find repeated word in the sentence.");
            new DuplicateWordsInSentence().Run();

            Console.WriteLine("Reverse Singly Linked List:");
            new SinglyLinkedListTest().Run();

            Console.WriteLine("Find second largest number in an array?");
            new ArrayTest().Run();

            Console.WriteLine("Sort a queue");
            new QueueTest().Run();

            Console.WriteLine("Runnign the old-school fibonacci");
            new Fibonacci().Print(145);

            Console.WriteLine("Find Max Diff Between Items in Array");
            new FindMaxDiffBetweenItems().Run();
        }
    }
}
