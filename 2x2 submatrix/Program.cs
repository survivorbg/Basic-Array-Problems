using System;

namespace _2x2_submatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The 2x2 submatrix that has the biggest sum of its elements.
            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };
            var bestSum = int.MinValue;
            var bestRow = 0;
            var bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++) //row < 3
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++) //col < 5
                {

                    int sum = matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];
                    Console.WriteLine($"Matrix(2x2) starting from row:{row} col:{col} = {matrix[row, col]} + {matrix[row, col + 1]} + {matrix[row + 1, col]} + {matrix[row + 1, col + 1]} = {sum}");
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }

                }

            }
            Console.WriteLine($"Row: {bestRow} Col: {bestCol} | {matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} = {bestSum}");






        }
    }
}
