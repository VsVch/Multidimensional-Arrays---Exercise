using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }

            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputArray[0] != "swap" || inputArray.Length != 5)
                {
                    Console.WriteLine($"Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(inputArray[1]);
                    int col1 = int.Parse(inputArray[2]);
                    int row2 = int.Parse(inputArray[3]);
                    int col2 = int.Parse(inputArray[4]);
                    if (row1 >=0 & row2 >= 0 & col1>=0 & col2 >= 0 & row1 < matrix.GetLength(0) & row2 < matrix.GetLength(0) & col1 < matrix.GetLength(1) & col2 < matrix.GetLength(1))
                    {
                        int cur = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];

                        matrix[row2, col2] = cur;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }


                input = Console.ReadLine();
            }
        }
    }
}
