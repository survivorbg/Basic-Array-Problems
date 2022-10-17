using System;

namespace Reversed_Array__from_console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            var length = array.Length;
            int[] reversedArray = new int[length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[reversedArray.Length - 1 - i] = array[i];
            }

            for (int i = 0; i < reversedArray.GetLength(0); i++)
            {
                Console.Write(reversedArray[i] + " ");
            }


        }
    }
}
