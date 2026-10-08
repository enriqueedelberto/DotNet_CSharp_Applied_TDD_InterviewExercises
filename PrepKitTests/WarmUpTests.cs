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
        [InlineData(8, "DDUUUUDD", 1)]
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

        [Theory]
        [InlineData(7, new int []{1,2,1,2,3,2}, 2)] 
        public void SockMerchant_CountPairs_Test1(int n, int[] ar, int expectedResult )
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
            var result = SockMerchant.CountPairs(n, arList);

            //Assert
            Assert.Equal(expectedResult, result );
        }

        
    }
}