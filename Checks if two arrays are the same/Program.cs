using System;

namespace Checks_if_two_arrays_are_the_same
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much elements you want in the arrays?");
            int lengthOfTheArrays = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[lengthOfTheArrays];
            int[] numbers2 = new int[lengthOfTheArrays];
            bool areTheSame = true;
            Console.WriteLine($"Write {lengthOfTheArrays} numbers for the first array");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {

                int elementArray1 = int.Parse(Console.ReadLine());
                numbers1[i] = elementArray1;
            }
            Console.WriteLine($"Write {lengthOfTheArrays} numbers for the second array");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                int elementArray1 = int.Parse(Console.ReadLine());
                numbers2[i] = elementArray1;
            }

            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                if (!(numbers1[i] == numbers2[i]))
                {
                    areTheSame = false;
                }
            }

            if (areTheSame)
            {
                Console.WriteLine("They are the same!");
            }
            else
            {
                Console.WriteLine("They are not the same.");
            }
        }
    }
}
