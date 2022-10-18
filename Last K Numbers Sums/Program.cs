using System;
using System.Numerics;

namespace Last_K_Numbers_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); //6 
            var k = int.Parse(Console.ReadLine()); //2

            BigInteger[] nums = new BigInteger[n];
            nums[0] = 1;
            for (int i = 1; i < n; i++)
            {
                BigInteger sum = 0L;
                for (int previous = i - k; previous <= i-1; previous++)
                {
                    if (previous >= 0)
                    {
                        sum += nums[previous];
                    }
                }
                nums[i] = sum;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
