using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        public static bool IsvalidIndex(int row, int col, double[][] jaggedMatrix)
        { return row >= 0 && row < jaggedMatrix.Length && col >= 0 && col < jaggedMatrix[row].Length; }

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[rows][];




            for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
            {
                jaggedMatrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            }
            for (int row = 0; row < jaggedMatrix.Length - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(x => x * 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x * 2).ToArray();

                }
                else
                {
                    jaggedMatrix[row] = jaggedMatrix[row].Select(x => x / 2).ToArray();
                    jaggedMatrix[row + 1] = jaggedMatrix[row + 1].Select(x => x / 2).ToArray();
                }
            }





            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandsArray = commandArray[0];
                int row = int.Parse(commandArray[1]);
                int col = int.Parse(commandArray[2]);
                int value = int.Parse(commandArray[3]);
                bool isValid = IsvalidIndex(row, col, jaggedMatrix);
                if (isValid)
                {
                    if (commandsArray == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (commandsArray == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write(jaggedMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }





        }
    }
}
