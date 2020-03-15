using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(12.2);
            book.AddGrade(43.2);
            book.AddGrade(15.6);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(23.7, result.Average, 1);
            Assert.Equal(43.2, result.High);
            Assert.Equal(12.2, result.Low);

        }
    }
}
