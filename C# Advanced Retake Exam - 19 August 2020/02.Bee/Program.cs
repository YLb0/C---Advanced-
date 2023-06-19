using System;

namespace _02._Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int rowB = 0;
            int colB = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'B')
                    {
                        rowB = row;
                        colB = col;
                    }
                }
            }
            string command = Console.ReadLine();
            int count = 0;
            while (command != "End")
            {
                try
                {
                    if (command == "up")
                    {
                        matrix[rowB, colB] = '.';
                        rowB--;
                        if (matrix[rowB, colB] == 'f')
                        {
                            matrix[rowB, colB] = '.';
                            count++;
                        }
                        else if (matrix[rowB, colB] == 'O')
                        {
                            matrix[rowB, colB] = '.';
                            rowB--;
                            if (matrix[rowB, colB] == 'f')
                            {
                                matrix[rowB, colB] = '.';
                                count++;
                            }
                        }
                        matrix[rowB, colB] = 'B';
                    }
                    else if (command == "down")
                    {
                        matrix[rowB, colB] = '.';
                        rowB++;
                        if (matrix[rowB, colB] == 'f')
                        {
                            matrix[rowB, colB] = '.';
                            count++;
                        }
                        else if (matrix[rowB, colB] == 'O')
                        {
                            matrix[rowB, colB] = '.';
                            rowB++;
                            if (matrix[rowB, colB] == 'f')
                            {
                                matrix[rowB, colB] = '.';
                                count++;
                            }
                        }
                        matrix[rowB, colB] = 'B';
                    }
                    else if (command == "left")
                    {
                        matrix[rowB, colB] = '.';
                        colB--;
                        if (matrix[rowB, colB] == 'f')
                        {
                            matrix[rowB, colB] = '.';
                            count++;
                        }
                        else if (matrix[rowB, colB] == 'O')
                        {
                            matrix[rowB, colB] = '.';
                            colB--;
                            if (matrix[rowB, colB] == 'f')
                            {
                                matrix[rowB, colB] = '.';
                                count++;
                            }
                        }
                        matrix[rowB, colB] = 'B';
                    }
                    else if (command == "right")
                    {
                        matrix[rowB, colB] = '.';
                        colB++;
                        if (matrix[rowB, colB] == 'f')
                        {
                            matrix[rowB, colB] = '.';
                            count++;
                        }
                        else if (matrix[rowB, colB] == 'O')
                        {
                            matrix[rowB, colB] = '.';
                            colB++;
                            if (matrix[rowB, colB] == 'f')
                            {
                                matrix[rowB, colB] = '.';
                                count++;
                            }
                        }
                        matrix[rowB, colB] = 'B';
                    }
                    command = Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }
            }
            if (count >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {count} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - count} flowers more");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
