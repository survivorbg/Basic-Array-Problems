using System;

namespace Sooner_in_lexicographical_sense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charactersArray1 = new char[] { 'b', 'a', 'b', 'c', 'b' };
            char[] charactersArray2 = new char[] { 'a', 'c', 'b' };
            int biggerLength;

            if (charactersArray1.Length > charactersArray2.Length)
            {
                biggerLength = charactersArray1.Length;
            }
            else
            {
                biggerLength = charactersArray2.Length;
            }

            for (int i = 0; i < biggerLength; i++)
            {
                try
                {
                    if (charactersArray1[i] < charactersArray2[i])
                    {
                        Console.WriteLine("Array 1 is sooner in lexicographical sense.");
                        return;
                    }
                    else if (charactersArray1[i] > charactersArray2[i])
                    {
                        Console.WriteLine("Array 2 is sooner in lexicographical sense.");
                        return;
                    }
                }
                catch
                {
                    if (charactersArray1.Length > charactersArray2.Length)
                    {
                        Console.WriteLine("Array 2 is sooner in lexicographical sense.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Array 1 is sooner in lexicographical sense.");
                        return;
                    }
                }
            }
            Console.WriteLine("They are the same in lexicographical sense.");



        }
    }
}
