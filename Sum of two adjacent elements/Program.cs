using System;

namespace Sum_of_two_adjacent_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes one array and creates
            //another whose elements are the sum of every
            //two adjacent ones, starting at zero.

            int[] numArr1 = { 4, 8, 7, 2, 5, 1 };
            int[] numArr2 = new int[(numArr1.Length + 1) / 2];
            var index = 0;
            for (int i = 0; i <= numArr2.Length + 1; i += 2)
            {
                numArr2[index] = numArr1[i] + numArr1[i + 1];
                index++;
            }
            Console.WriteLine(String.Join(',', numArr2));

        }
    }
}
