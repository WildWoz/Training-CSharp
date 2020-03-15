using GradeBook;
using System;
using System.Collections.Generic;


namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Adam's Grade Book");

            while (true)
            {
                Console.WriteLine("Input a grade or press 'q' to exit.");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            book.GetStatistics();

            var stats = book.GetStatistics();
            Console.WriteLine($"Average: {stats.Average:N1}");
            Console.WriteLine($"Lowest: {stats.Low:N1}");
            Console.WriteLine($"Highest: {stats.High:N1}");
            Console.WriteLine($"Letter: {stats.Letter}");

        }
    }
}
