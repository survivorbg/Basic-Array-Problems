using System;
using System.Linq;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            //със друг масив

            //var reversedNumbers = new int[numbers.Length];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            //}

            //с функция

            //var reversedNumbers = numbers.Reverse().ToArray();
            //Console.WriteLine(String.Join(' ',reversedNumbers));

            //3-ти начин
            Console.WriteLine(String.Join(',', Console.ReadLine().Split(' ').Reverse()));


        }
    }
}
