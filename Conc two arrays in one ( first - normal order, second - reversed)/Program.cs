using System;

namespace Conc_two_arrays_in_one___first___normal_order__second___reversed_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have two arrays. Make third arrray which contains all elements from the first
            //array(normal order) and all elements from the second array, but in reversed order.
            int[] numArr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] numArr2 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] numArr3 = new int[numArr1.Length + numArr2.Length];


            for (int i = 0; i < numArr1.Length; i++)
            {
                numArr3[i] = numArr1[i];
            }
            for (int i = 0; i < numArr2.Length; i++)
            {
                numArr3[i + numArr1.Length] = numArr2[numArr2.Length - 1 - i];
            }
            Console.WriteLine(String.Join(',', numArr3));
        }
    }
}
