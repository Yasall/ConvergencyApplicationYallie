using System;
using System.Collections.Generic;

namespace ConvergencyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FibArr();
        }

        public static void FibArr()
        {
            List<int> seq = new List<int>();
            for (int i = 0; i < 5000000; i++)
            {
                if (PerfectSquare(5 * i * i + 4) || PerfectSquare(5 * i * i - 4))
                {
                    seq.Add(i);

                }

            }
            int sum = 0;
            foreach (var item in seq)
            {
                if (item % 2 == 0)
                    sum += item;
            }
            Console.WriteLine(sum);
        }
        public static bool PerfectSquare(int num)
        {
            int n = (int)(Math.Sqrt(num));
            return (n * n == num);
        }
    }
}
