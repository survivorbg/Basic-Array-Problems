using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rounding away from zero

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int rounded = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                //int rounded = (numbers[i] >= 0) ? (int)(numbers[i] + 0.5) : (int)(numbers[i] - 0.5);
                Console.WriteLine($"{numbers[i]} => {rounded}");
            }
        }
    }
}
