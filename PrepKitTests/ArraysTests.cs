using InterviewPrepKit.Arrays;

namespace PrepKitTests;

public class ArraysTests
{
    [Fact]
    public void LeftRotateTest()
    {

        var numOfRotations = 4;
        var inputArray = new List<int>() { 1, 2, 3, 4, 5 };
        var resultList = LeftRotate.rotLeft(inputArray, numOfRotations);
        var expectedList = new List<int>() { 5, 1, 2, 3, 4 };

        Assert.True(areArraysEqual(expectedList, resultList));
    }

    private bool areArraysEqual(List<int> startArray, List<int> finalArray)
    {
        for (int i = 0; i < startArray.Count; i++)
        {
            if (startArray[i] != finalArray[i])
            {
                return false;
            }
        }

        return true;
    }
}
