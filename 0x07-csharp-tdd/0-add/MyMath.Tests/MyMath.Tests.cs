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
            int a = 1;
            int b = 4;

            // Act
            int sum = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(5, sum);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            int a = -3;
            int b = 5;

            // Act
            int sum = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(2, sum);
        }
        
        [Test]
        public void Test3()
        {
            // Arrange
            int a = 0;
            int b = 0;

            // Act
            int sum = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            int a = -3;
            int b = -2;

            // Act
            int sum = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(-5, sum);
        }
    }
}