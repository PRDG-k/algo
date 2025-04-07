using System;

namespace MaxSum
{
    internal class Program
    {
        public static int fastestMaxSum(int[] arr)
        {
            int N = arr.Length;
            int ret = int.MinValue;
            int psum = 0;

            for (int i = 0; i < N; i++)
            {
                psum = Math.Max(psum, 0) + arr[i];
                ret = Math.Max(ret, psum);
            }
            return ret;
        }
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int result = fastestMaxSum(arr);
            Console.WriteLine("The maximum sum of a contiguous subarray is: " + result);
        }
    }
}
