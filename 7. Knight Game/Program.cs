using System;

namespace knightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int[,] mooves = new int[n, n];

            int count = 0;
            while (true)
            {
                int maxCountMoves = int.MinValue;
                int row = 0;
                int col = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i][j] == 'K')
                        {
                            if (i - 1 > -1 && i - 1 < matrix.Length && j - 2 > -1 && j - 2 < matrix[i - 1].Length)
                            {
                                if (matrix[i - 1][j - 2] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }
                            if (i - 1 > -1 && i - 1 < matrix.Length && j + 2 > -1 && j + 2 < matrix[i - 1].Length)
                            {
                                if (matrix[i - 1][j + 2] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }

                            if (i + 1 > -1 && i + 1 < matrix.Length && j - 2 > -1 && j - 2 < matrix[i + 1].Length)
                            {
                                if (matrix[i + 1][j - 2] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }
                            if (i + 1 > -1 && i + 1 < matrix.Length && j + 2 > -1 && j + 2 < matrix[i + 1].Length)
                            {
                                if (matrix[i + 1][j + 2] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }
                            if (i - 2 > -1 && i - 2 < matrix.Length && j - 1 > -1 && j - 1 < matrix[i - 2].Length)
                            {
                                if (matrix[i - 2][j - 1] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }
                            if (i - 2 > -1 && i - 2 < matrix.Length && j + 1 > -1 && j + 1 < matrix[i - 2].Length)
                            {
                                if (matrix[i - 2][j + 1] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }
                            if (i + 2 > -1 && i + 2 < matrix.Length && j - 1 > -1 && j - 1 < matrix[i + 2].Length)
                            {
                                if (matrix[i + 2][j - 1] == 'K')
                                {
                                    mooves[i, j]++;

                                }
                            }
                            if (i + 2 > -1 && i + 2 < matrix.Length && j + 1 > -1 && j + 1 < matrix[i + 2].Length)
                            {
                                if (matrix[i + 2][j + 1] == 'K')
                                {
                                    mooves[i, j]++;
                                }
                            }

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mooves[i, j] > maxCountMoves)
                        {
                            maxCountMoves = mooves[i, j];
                            row = i;
                            col = j;
                        }
                    }
                }
                if (maxCountMoves > 0)
                {
                    matrix[row][col] = '0';
                    count++;
                    mooves = new int[n, n];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}