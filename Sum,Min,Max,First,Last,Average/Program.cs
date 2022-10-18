using System;
using System.Linq;

namespace Sum_Min_Max_First_Last_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50,20,25,40 };
            
            var sum = 0;
            var min = int.MaxValue;
            var max = int.MinValue;
            var first = 0;
            var last = 0;



            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                if (max < numbers[i])
                {
                    max = numbers[i];
                }

            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"First = {numbers[0]}");
            Console.WriteLine($"Last = {numbers[numbers.Length - 1]}");
            Console.WriteLine($"Average = {(double)sum/numbers.Length}");



            //with functions only
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.First());
            Console.WriteLine(numbers.Last());
            Console.WriteLine(numbers.Average());
















        }
    }
}
