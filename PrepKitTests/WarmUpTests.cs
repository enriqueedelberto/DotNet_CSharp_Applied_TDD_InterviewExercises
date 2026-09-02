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
        [Fact]
        public void ValleyCountingTest1()
        {
            //Arrange
            var expectedResult = 1;
            var steps = 8;
            var path = "UDDDUDUU";

            //Act
            var result = ValleyCounting.CountValleys(steps, path);

            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}