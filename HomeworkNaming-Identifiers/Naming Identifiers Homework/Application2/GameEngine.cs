using System;
using System.Collections.Generic;

namespace MinesweeperGame
{
    public class GameEngine
    {
        private const int Max = 35;

        private readonly List<Ranking> champions = new List<Ranking>(6);

        private bool flag = true;

        private bool flag2 = false;

        private string command = string.Empty;

        private char[,] gameField = CreateGameField();

        private char[,] mines = SetMines();

        private int counter = 0;

        private bool bomb = false;

        private int row = 0;

        private int col = 0;

        public void Run()
        {
            do
            {
                if (this.flag)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    Dump(this.gameField);
                    flag = false;
                }

                Console.Write("Daj red i kolona : ");
                this.command = Console.ReadLine().Trim();

                if (this.command.Length >= 3)
                {
                    if (int.TryParse(this.command[0].ToString(), out this.row) && 
                        int.TryParse(this.command[2].ToString(),out this.col)
                        && this.row <= this.gameField.GetLength(0) && this.col <= this.gameField.GetLength(1))
                    {
                        this.command = "turn";
                    }
                }

                switch (this.command)
                {
                    case "top":
                        GetRanking(champions);
                        break;
                    case "restart":
                        this.gameField = CreateGameField();
                        this.mines = SetMines();
                        Dump(this.gameField);
                        this.bomb = false;
                        this.flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (this.mines[this.row,this.col] != '*')
                        {
                            if (this.mines[this.row, this.col] == '-')
                            {
                                ChangeTurn(this.gameField, this.mines, this.row, this.col);
                                this.counter++;
                            }

                            if (Max == this.counter)
                            {
                                this.flag2 = true;
                            }
                            else
                            {
                                Dump(this.gameField);
                            }
                        }
                        else
                        {
                            this.bomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (this.bomb)
                {
                    Dump(this.mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", this.counter);
                    string nickname = Console.ReadLine();
                    Ranking t = new Ranking(nickname,this.counter);
                    if (this.champions.Count < 5)
                    {
                        this.champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < this.champions.Count; i++)
                        {
                            if (this.champions[i].Points < t.Points)
                            {
                                this.champions.Insert(i, t);
                                this.champions.RemoveAt(this.champions.Count - 1);
                                break;
                            }
                        }
                    }

                    this.champions.Sort((Ranking r1, Ranking r2) => r2.Player.CompareTo(r1.Player));
                    this.champions.Sort((Ranking r1, Ranking r2) => r2.Points.CompareTo(r1.Points));
                    GetRanking (this.champions);

                    this.gameField = CreateGameField();
                    this.mines = SetMines();
                    this.counter = 0;
                    this.bomb = false;
                    this.flag = true;
                }

                if (this.flag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    Dump(this.mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Ranking points = new Ranking(name, this.counter);
                    this.champions.Add(points);
                    GetRanking(this.champions);
                    this.gameField = CreateGameField();
                    this.mines = SetMines();
                    this.counter = 0;
                    this.flag2 = false;
                    this.flag = true;
                }
            }
            while (this.command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GetRanking(List<Ranking> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Player, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void ChangeTurn(char[,] gameField, char[,] mines, int row, int col)
        {
            char numberOfMines = CountMines(mines, row, col);
            mines[row, col] = numberOfMines;
            gameField[row, col] = numberOfMines;
        }

        private static void Dump(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int newMine = random.Next(50);
                if (!mines.Contains(newMine))
                {
                    mines.Add(newMine);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / cols;
                int row = mine % rows;
                if (row == 0 && mine != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void Calculation(char[,] gameField)
        {
            int col = gameField.GetLength(0);
            int row = gameField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char count = CountMines(gameField, i, j);
                        gameField[i, j] = count;
                    }
                }
            }
        }

        private static char CountMines(char[,] field, int currentRow, int currentColumn)
        {
            int mineCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (field[currentRow + 1, currentColumn] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn - 1 >= 0)
            {
                if (field[currentRow, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (currentColumn + 1 < columns)
            {
                if (field[currentRow, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow - 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentColumn + 1 < columns))
            {
                if (field[currentRow - 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn - 1 >= 0))
            {
                if (field[currentRow + 1, currentColumn - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((currentRow + 1 < rows) && (currentColumn + 1 < columns))
            {
                if (field[currentRow + 1, currentColumn + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }
    }
}