namespace Matrix
{
    using System;

    public class WalkInMatrix
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = MatrixGenerator(size);

            PrintMatrix(size, matrix);
        }

        public static int[,] MatrixGenerator(int size)
        {
            int[,] matrix = new int[size, size];

            int x = 0;
            int y = 0;
            int deltaX = 1;
            int deltaY = 1;

            int stepCount = 0;

            while (stepCount < matrix.Length)
            {
                stepCount++;
                matrix[x, y] = stepCount;

                int nextX = x + deltaX;
                int nextY = y + deltaY;

                bool isNextX = 0 <= nextX && nextX < matrix.GetLength(0);
                bool isNextY = 0 <= nextY && nextY < matrix.GetLength(1);
                bool isNextCell = false;
                bool jumpedToEmptyCell = false;

                if (isNextX && isNextY)
                {
                    isNextCell = matrix[nextX, nextY] != 0;
                }

                int loopCount = 0;
                while (!isNextX || !isNextY || isNextCell)
                {
                    ChangeDirection(ref deltaX, ref deltaY);

                    nextX = x + deltaX;
                    nextY = y + deltaY;

                    isNextX = 0 <= nextX && nextX < matrix.GetLength(0);
                    isNextY = 0 <= nextY && nextY < matrix.GetLength(1);

                    if (isNextX && isNextY)
                    {
                        isNextCell = matrix[nextX, nextY] != 0;
                    }

                    loopCount++;

                    if (loopCount == 7)
                    {
                        SetPositionToFirstEmptyCell(matrix, out x, out y);
                        jumpedToEmptyCell = true;
                        break;
                    }
                }

                if (!jumpedToEmptyCell)
                {
                    x += deltaX;
                    y += deltaY;
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void ChangeDirection(ref int deltaX, ref int deltaY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            for (int index = 0; index < 8; index++)
            {
                if (directionsX[index] == deltaX && directionsY[index] == deltaY)
                {
                    currentDirection = index;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                deltaX = directionsX[0];
                deltaY = directionsY[0];
            }
            else
            {
                deltaX = directionsX[currentDirection + 1];
                deltaY = directionsY[currentDirection + 1];
            }
        }

        static bool proverka(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void SetPositionToFirstEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }
    }
}
