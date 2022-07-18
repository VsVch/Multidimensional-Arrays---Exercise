using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];



            string input = Console.ReadLine();
            int snakeCounter = 0;
            
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 0; i < matrix.GetLength(0) * matrix.GetLength(1); i++)
            {
                char ch = input[snakeCounter];
                snakeCounter++;
                if (snakeCounter == input.Length)
                {
                    snakeCounter = 0;
                }

                matrix[row, col] = ch;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }

                if (col == matrix.GetLength(1) && direction == "right")
                {
                    col--;
                    row++;
                    direction = "left";
                }
                if (col == -1 && direction == "left")
                {
                    col++;
                    row++;
                    direction = "right";
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
