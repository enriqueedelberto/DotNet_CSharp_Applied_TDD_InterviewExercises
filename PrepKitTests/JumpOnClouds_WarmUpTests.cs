using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewPrepKit.WarmUpChallenges;
using Xunit;

namespace PrepKitTests
{
    public class JumpOnClouds_WarmUpTests
    {
        

        [Theory]
        [InlineData(new int[] { 0, 1, 0  }, 1)] //trivial 
        public void CloudJumping_JumpOnClouds_Trivial_Test( int[] ar, int expectedResult )
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
             var result = CloudJumping.JumpOnClouds(arList);

            //Assert
            Assert.Equal(expectedResult, result );
        } 

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 0, 0, 1, 0 }, 3)] //Solve 
        public void CloudJumping_JumpOnClouds_Difficult_One_Test(int[] ar, int expectedResult)
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
            var result = CloudJumping.JumpOnClouds(arList);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory] 
        [InlineData(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)] //Solve 
        public void CloudJumping_JumpOnClouds_Difficult_Two_Test(int[] ar, int expectedResult)
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
            var result = CloudJumping.JumpOnClouds(arList);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory] 
        [InlineData(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
        public void CloudJumping_JumpOnClouds_Difficult_Three_Test(int[] ar, int expectedResult)
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
            var result = CloudJumping.JumpOnClouds(arList);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 0, 0, 0,  1, 0, 0 }, 3)]
        public void CloudJumping_JumpOnClouds__Run_Test(int[] ar, int expectedResult)
        {
            //Arrange  
            var arList = ar.ToList();
            //Act
            var result = CloudJumping.JumpOnClouds(arList);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}