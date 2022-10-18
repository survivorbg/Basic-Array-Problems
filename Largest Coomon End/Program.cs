using System;

namespace Largest_Coomon_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays of words and find the length of the largest common end(left or right)
            //hi php java csharp sql html css js
            //hi php java js softuni nakov java learn
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            var count = 0;
            var oldCount = 0;

            var shortestLength = (arr1.Length <= arr2.Length) ? arr1.Length : arr2.Length;

            for (int i = 0; i < shortestLength; i++)
            {
                //TODO
            }





        }
    }
}
