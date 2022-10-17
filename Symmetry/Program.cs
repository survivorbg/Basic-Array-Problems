using System;

namespace _3.Symmetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Checks if the array is symmetric.

            int[] myArray = { 1, 2, 3, 4, 3, 2, 1 };
            bool symmetry = true;

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                if (myArray[i] != myArray[myArray.Length - 1 - i])
                {
                    symmetry = false;
                }
            }
            if (symmetry)
            {
                Console.WriteLine("It's symmetric.");
            }
            else { Console.WriteLine("It's not symmetric."); }
        }

    }
}
