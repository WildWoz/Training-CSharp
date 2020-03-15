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
            book.AddGrade(7.8);
            book.AddGrade(72.86);
            book.AddGrade(57.28);
            book.GetStatistics();

            var stats = book.GetStatistics();
            Console.WriteLine($"Average: {stats.Average:N1}");
            Console.WriteLine($"Lowest: {stats.Low:N1}");
            Console.WriteLine($"Highest: {stats.High:N1}");

        }
    }
}
