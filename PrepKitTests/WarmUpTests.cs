using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepKit.WarmUpChallenges;
using Xunit;

namespace PrepKitTests
{
    public class WarmUpTests
    {
        [Theory]
        [InlineData(8, "UDDDUDUU", 1)]
        [InlineData(12, "DDUUDDUDUUUD", 2)]
        public void ValleyCountingTest1(int steps, string path, int expectedResult )
        {
            //Arrange  
            //Act
            var result = ValleyCounting.CountValleys(steps, path);

            //Assert
            Assert.Equal(expectedResult, result );
        }


        [Theory]
        [InlineData(10, "DUDDDUUDUU", 2)] 
        public void ValleyCountingTest_Failed(int steps, string path, int expectedResult )
        {
            //Arrange  
            //Act
            var result = ValleyCounting.CountValleys(steps, path);

            //Assert
            Assert.Equal(expectedResult, result );
        }
    }
}