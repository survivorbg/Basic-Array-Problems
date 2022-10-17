using System;

namespace One_index_to_the_left
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    break;
                }
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = temp;
            Console.WriteLine(String.Join(',', numbers));

        }
    }
}
