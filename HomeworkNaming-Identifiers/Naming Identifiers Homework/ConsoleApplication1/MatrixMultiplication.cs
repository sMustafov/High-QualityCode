using System;

namespace ConsoleApplication1
{
    class MatrixMultiplication
    {
        static void Main()
        {
            var firstMatrix = new double[,]
            {
                { 1, 3 }, 
                { 5, 7 }
            };
            var secondMatrix = new double[,]
            {
                { 4, 2 }, 
                { 1, 5 }
            };

            var productMatrix = MultiplyMatrices(firstMatrix, secondMatrix);

            for (int row = 0; row < productMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < productMatrix.GetLength(1); col++)
                {
                    Console.Write(productMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static double[,] MultiplyMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("The columns number of the first matrix must be equal to the rows number of the second matrix.");
            }

            var firstMatrixLength = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < firstMatrixLength; k++)
                    {
                        resultMatrix[i, j] += firstMatrix[i, k]*secondMatrix[k, j];
                    }
                }
            }
            return resultMatrix;
        }
    }
}