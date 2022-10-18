using System;
using System.Linq;

namespace Reading_Array_Values_from_a_Single_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();
            string[] tokens = line.Split(' ');
            int[] nums = tokens.Select(int.Parse).ToArray();

            //още по-кратък начин
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

         












        }
    }
}
