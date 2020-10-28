using System;
using System.Collections.Generic;
using System.Linq;

namespace HistagramProblem
{
    public static class Utility
    {
        static int lowerIndex(List<int> arr, int n, int x)
        {
            int l = 0, h = n - 1;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] >= x)
                    h = mid - 1;
                else
                    l = mid + 1;
            }
            return l;
        }

        // function to find last index <= y 
        static int upperIndex(List<int> arr, int n, int y)
        {
            int l = 0, h = n - 1;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] <= y)
                    l = mid + 1;
                else
                    h = mid - 1;
            }
            return h;
        }

        // function to count elements  
        // within given range 
        public static int countInRange(List<int> arr, int n, int x, int y)
        {
            // initialize result 
            int count = 0;
            count = upperIndex(arr, n, y) -
                    lowerIndex(arr, n, x) + 1;
            return count;
        }
        public static void ConvertToBucket(List<int> arr, int bucketSize)
        {
            int bucketStart = 0;
            int BucketLimit = 80;// max elemnt
            int currentBucketlimit = 0;
            arr.Sort();
            while (currentBucketlimit < BucketLimit)
            {
                var count = Utility.countInRange(arr, arr.Count(), bucketStart, bucketStart + bucketSize);
                Console.WriteLine("{0} to {1} :{2} ", (bucketStart == 0) ? 1 : bucketStart, bucketStart + bucketSize, count);
                bucketStart = bucketStart + bucketSize;
                currentBucketlimit = bucketSize + currentBucketlimit;
            }
        }
    }
}
