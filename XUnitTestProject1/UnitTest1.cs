using System;
using System.Collections.Generic;
using HistagramProblem;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertToBucket_Should_Run_Sucessfully_withValid_Parameter()
        {
            var inputArray = new List<int>();
            inputArray.Add(1);
            inputArray.Add(2);
            inputArray.Add(3);
            inputArray.Add(4);
            int bucketSize= 5;
            Utility.ConvertToBucket(inputArray, bucketSize);
        }

        [Fact]
        public void CountInRange_Should_Return_valid_With_valid_Parameter()
        {
            var inputArray = new List<int>();
            inputArray.Add(1);
            inputArray.Add(2);
            inputArray.Add(3);
            inputArray.Add(4);
            int bucketSize = 5;
            int actual =  Utility.countInRange(inputArray, inputArray.Count,1,5);
            int expected = 4;
            Assert.Equal(actual, expected);
        }

    }
}
