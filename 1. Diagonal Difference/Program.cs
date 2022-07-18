using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }

            }
            int sumLeft = 0;
            int sumRight = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                    sumLeft += matrix[row, row];
                    sumRight += matrix[row, matrix.GetLength(0)- 1 -row];
            }
            int diff = Math.Abs(sumLeft-sumRight);
            Console.WriteLine(diff);
        }
    }
}
