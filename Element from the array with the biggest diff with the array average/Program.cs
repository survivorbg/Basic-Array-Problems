using System;
using System.Linq;

namespace Element_from_the_array_with_the_biggest_diff_with_the_array_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -2, 15, 18, -7, 6, 7, 8 };

            var averageNumInNumbers = numbers.Average();
            double biggestDiff = double.MinValue;
            var startingDiff = Math.Abs(averageNumInNumbers - numbers[0]);
            var theNumber = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (averageNumInNumbers - numbers[i] > startingDiff)
                {
                    biggestDiff = averageNumInNumbers - numbers[i];
                    theNumber = numbers[i];
                    startingDiff = biggestDiff;
                }
            }
            Console.WriteLine(biggestDiff);
            Console.WriteLine(theNumber);



        }
    }
}
