using System;
using System.Linq;

namespace JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = new int[row, col];
            matrix = PopulateMatrix(matrix, row, col);

            string command = Console.ReadLine();
            long ivoStarSum = 0;

            while (command != "Let the Force be with you")
            {
                int[] ivoStart = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilStrat = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                EvilStarPath(evilStrat, matrix);
                ivoStarSum += IvoStarPath(ivoStart, matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(ivoStarSum);

        }

        public static int[,] PopulateMatrix(int[,] matrix, int x, int y)
        {
            int value = 0;

            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            return matrix;
        }

        public static int[,] EvilStarPath(int[] evilStart, int[,] matrix)
        {
            int evilRow = evilStart[0];
            int evilCol = evilStart[1];

            while (evilRow >= 0 && evilCol >= 0)
            {
                if (evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }

            return matrix;
        }

        public static long IvoStarPath(int[] ivoStart, int[,] matrix)
        {
            int ivoRow = ivoStart[0];
            int ivoCol = ivoStart[1];
            long ivoStarSum = 0;

            while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
            {
                if (ivoRow >= 0 && ivoRow < matrix.GetLength(0) && ivoCol >= 0 && ivoCol < matrix.GetLength(1))
                {
                    ivoStarSum += matrix[ivoRow, ivoCol];
                }

                ivoCol++;
                ivoRow--;
            }

            return ivoStarSum;
        }
    }
}
