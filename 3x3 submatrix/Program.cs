using System;

namespace _3x3_submatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the 3x3 submatrix that has the biggest sum of its elements.
            int[,] matrix =
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 },
                { 4, 6, 7, 9, 1, 0 },
                { 0, 2, 4, 0, 9, 5 }
            };
            var bestSum = int.MinValue;
            var bestRow = 0;
            var bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++) //row < 3
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++) //col < 5
                {

                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2]
                        ;
                    Console.WriteLine($"Matrix(2x2) starting from row:{row} col:{col} = {matrix[row, col]} + {matrix[row, col + 1]} + {matrix[row, col + 2]} + {matrix[row + 1, col]}+ {matrix[row + 1, col + 1]}+ {matrix[row + 1, col + 2]} + {matrix[row + 2, col]} + {matrix[row + 2, col + 1]}+ {matrix[row + 2, col + 2]} = {sum}");
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }

                }

            }
            Console.WriteLine($"Row: {bestRow} Col: {bestCol} | {matrix[bestRow, bestCol]} + {matrix[bestRow, bestCol + 1]} + {matrix[bestRow, bestCol + 2]} + {matrix[bestRow + 1, bestCol]}+ {matrix[bestRow + 1, bestCol + 1]}+ {matrix[bestRow + 1, bestCol + 2]} + {matrix[bestRow + 2, bestCol]} + {matrix[bestRow + 2, bestCol + 1]}+ {matrix[bestRow + 2, bestCol + 2]} = {bestSum}");





        }
    }
}
