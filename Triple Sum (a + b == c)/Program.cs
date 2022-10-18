using System;
using System.Globalization;
using System.Linq;

namespace Triple_Sum__a___b____c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool exist = false;
            for (int left = 0; left < numbers.Length; left++)
            {
                for (int right = left+1; right < numbers.Length; right++)
                {
                    var sum = numbers[left] + numbers[right];
                    if (numbers.Contains(sum))
                    {
                        exist = true;
                        Console.WriteLine($"{numbers[left]} + {numbers[right]} == {sum}");
                    }
                }
            }
            if (!exist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
