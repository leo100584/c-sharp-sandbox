using System;
using Xunit;

namespace GradeBook.Tests
{    
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            // // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.Average, 1);            
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

            // var x = 1;
            // var y = 2;

            // var actual = 3;
            // var expected = x+y;

            // Assert.Equal(actual,expected);
        }
    }
}
