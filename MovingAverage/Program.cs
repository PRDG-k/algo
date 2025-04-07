using System;
using System.Numerics;

namespace MovingAverage
{
    internal class Program
    {
        public static List<double> movingAverage(double[] A, int M)
        {
            List<double> ret = new List<double>(A.Length - M + 1);
            int N = A.Length;
            double partialSum = 0.0;
            for (int i = 0; i < M-1; ++i)
            {
                partialSum += A[i];
            }

            for (int i = M-1; i < N; ++i)
            {
                partialSum += A[i];
                ret.Add(partialSum / M);
                partialSum -= A[i - M + 1];
            }

            return ret;
        }

        static void Main(string[] args)
        {
            int size = 100;
            double[] A = new double[size];
            Random rand = new Random();

            for (int i = 0; i < size; ++i)
            {
                A[i] = rand.NextDouble() * 100;
            }

            List<double> ret = movingAverage(A, 5);

            Console.WriteLine("The moving average of the array is: ");

            for (int i = 0; i < ret.Count; ++i)
            {
                Console.WriteLine(ret[i]);
            }
        }
    }
}
