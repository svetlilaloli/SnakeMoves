using System;

namespace SnakeMoves
{
    class SnakeMoves
    {
        static void Main()
        {
            int[] matrixDimensions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            string snake = Console.ReadLine();
            char[,] stairs = new char[rows, cols];

            for (int i = 0, ch = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        stairs[i, j] = snake[ch];
                        if (ch == snake.Length - 1)
                        {
                            ch = 0;
                        }
                        else
                        {
                            ch++;
                        }
                    }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        stairs[i, j] = snake[ch];
                        if (ch == snake.Length - 1)
                        {
                            ch = 0;
                        }
                        else
                        {
                            ch++;
                        }
                    }
                }
            }
            // print the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(stairs[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
