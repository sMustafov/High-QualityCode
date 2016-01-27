namespace MatrixTest
{
    using Matrix;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestGenerateMatrixWithSizeOne()
        {
            int[,] matrix = WalkInMatrix.MatrixGenerator(1);

            int[,] expectedResult = { { 1 } };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestGenerateMatrixWithSizeThree()
        {
            int[,] matrix = WalkInMatrix.MatrixGenerator(6);

            int[,] expectedResult =
            {
                { 1, 16, 17 },
                { 15, 2, 27 },
                { 11, 10, 9 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestGenerateMatrixWithSizeSix()
        {
            int[,] matrix = WalkInMatrix.MatrixGenerator(6);

            int[,] expectedResult =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Assert.AreEqual(expectedResult[row, col], matrix[row, col]);
                }
            }
        }
    }
}
