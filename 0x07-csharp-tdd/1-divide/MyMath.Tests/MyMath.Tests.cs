using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            int[,] matrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };
            int [,] new_matrix = { {1, 2, 3}, {4, 5, 6} };
            int num = 2;

            // Act
            int [,] divmatrix = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(new_matrix, divmatrix);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            int[,] matrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };
            int num = 0;

            // Act
            int [,] divmatrix = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(divmatrix);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            int[,] matrix = null;
            int num = 0;

            // Act
            int [,] divmatrix = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(divmatrix);
        }
    }
}