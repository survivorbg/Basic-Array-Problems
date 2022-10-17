using System;

namespace Second_biggest_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 51, -751, 32, 213, 232, 129, 0 };
            int max = int.MinValue;
            int index = 0;
            int secondMax = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    index = i;
                    max = numbers[i];
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (secondMax < numbers[i] && i != 4)
                {
                    secondMax = numbers[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(index);
            Console.WriteLine($"Second max number in the array is {secondMax}.");

        }
    }
}
