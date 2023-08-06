namespace Sneaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            var field = new char[rowCount][];
            int samRow = 0;
            int samCol = 0;
            bool samWins = false;
            bool samDies = false;

            for (int row = 0; row < rowCount; row++)
            {
                field[row] = Console.ReadLine().ToCharArray();

                if (field[row].ToList().Contains('S'))
                {
                    samRow = row;
                    samCol = field[row].ToList().IndexOf('S');
                }
            }

            char[] command;

            command = Console.ReadLine().ToCharArray();

            for (int i = 0; i < command.Length; i++)
            {
                EnemiesTurn(field);

                var samCurrentRow = field[samRow].ToList();

                if (samCurrentRow.Contains('b'))
                {
                    if (samCurrentRow.IndexOf('b') < samCol)
                    {
                        field[samRow][samCol] = 'X';
                        samDies = true;
                        goto Result;
                    }
                }
                else if (samCurrentRow.Contains('d'))
                {
                    if (samCurrentRow.IndexOf('d') > samCol)
                    {
                        field[samRow][samCol] = 'X';
                        samDies = true;
                        goto Result;
                    }
                }

                switch (command[i])
                {
                    case 'U':
                        if (field[samRow - 1].ToList().Contains('N'))
                        {
                            if (field[samRow - 1][samCol] == 'N')
                            {
                                field[samRow - 1][samCol] = 'X';
                                samWins = true;
                                break;
                            }
                            else
                            {
                                field[samRow - 1][samCol] = 'S';
                                field[samRow - 1][field[samRow - 1].ToList().IndexOf('N')] = 'X';
                                field[samRow][samCol] = '.';
                                samWins = true;
                                samRow = samRow - 1;
                                break;
                            }
                        }
                        else
                        {
                            field[samRow - 1][samCol] = 'S';
                            field[samRow][samCol] = '.';
                            samRow = samRow - 1;
                            break;
                        }

                    case 'R':
                        field[samRow][samCol + 1] = 'S';
                        field[samRow][samCol] = '.';
                        samCol = samCol + 1;
                        break;

                    case 'D':
                        if (field[samRow + 1].ToList().Contains('N'))
                        {
                            if (field[samRow + 1][samCol] == 'N')
                            {
                                field[samRow + 1][samCol] = 'X';
                                samWins = true;
                                break;
                            }
                            else
                            {
                                field[samRow + 1][samCol] = 'S';
                                field[samRow + 1][field[samRow + 1].ToList().IndexOf('N')] = 'X';
                                field[samRow][samCol] = '.';
                                samWins = true;
                                samRow = samRow + 1;
                                break;
                            }
                        }
                        else
                        {
                            field[samRow + 1][samCol] = 'S';
                            field[samRow][samCol] = '.';
                            samRow = samRow + 1;
                            break;
                        }

                    case 'L':
                        field[samRow][samCol - 1] = 'S';
                        field[samRow][samCol] = '.';
                        samCol = samCol - 1;
                        break;
                }

                var samRowAfterMove = field[samRow].ToList();

                if (samRowAfterMove.Contains('b'))
                {
                    if (samRowAfterMove.IndexOf('b') < samCol)
                    {
                        field[samRow][samCol] = 'X';
                        samDies = true;
                        goto Result;
                    }
                }
                else if (samRowAfterMove.Contains('d'))
                {
                    if (samRowAfterMove.IndexOf('d') > samCol)
                    {
                        field[samRow][samCol] = 'X';
                        goto Result;
                    }
                }

            Result:
                if (samWins)
                {
                    Console.WriteLine("Nikoladze killed!");
                    for (int row = 0; row < field.Length; row++)
                    {
                        Console.WriteLine(string.Join("", field[row].ToList()));
                    }
                    break;
                }

                else if (samDies)
                {
                    Console.WriteLine("Sam died at {0}, {1}", samRow, samCol);

                    for (int row = 0; row < field.Length; row++)
                    {
                        Console.WriteLine(string.Join("", field[row].ToList()));
                    }
                    break;
                }
            }
        }

        public static void EnemiesTurn(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'b')
                    {
                        if (col < field[row].Length - 1)
                        {
                            field[row][col + 1] = 'b';
                            field[row][col] = '.';
                            break;
                        }
                        else if (col == field[row].Length - 1)
                        {
                            field[row][col] = 'd';
                            break;
                        }
                    }
                    else if (field[row][col] == 'd')
                    {
                        if (col > 0)
                        {
                            field[row][col - 1] = 'd';
                            field[row][col] = '.';
                            break;
                        }
                        else if (col == 0)
                        {
                            field[row][col] = 'b';
                            break;
                        }
                    }
                }
            }
        }
    }
}