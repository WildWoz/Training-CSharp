using GradeBook;
using System;
using System.Collections.Generic;


namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new InMemoryBook("Adam's Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            book.GetStatistics();

            var stats = book.GetStatistics();

            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"Book: {book.Name}");
            Console.WriteLine($"Average: {stats.Average:N1}");
            Console.WriteLine($"Lowest: {stats.Low:N1}");
            Console.WriteLine($"Highest: {stats.High:N1}");
            Console.WriteLine($"Letter: {stats.Letter}");

        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Input a grade or press 'q' to exit.");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade has been added.");
        }
    }

}
