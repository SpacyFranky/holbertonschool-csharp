using NUnit.Framework;
using System.Collections.Generic;

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
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(1);

            // Act
            int big = Operations.Max(nums);

            // Assert
            Assert.AreEqual(5, big);
        }

        [Test]
        public void Test2()
        {
            // Arrange
            List<int> nums = new List<int>();
            nums.Add(-3);
            nums.Add(-5);
            nums.Add(-1);

            // Act
            int big = Operations.Max(nums);

            // Assert
            Assert.AreEqual(-1, big);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(-5);
            nums.Add(-1);

            // Act
            int big = Operations.Max(nums);

            // Assert
            Assert.AreEqual(3, big);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            List<int> nums = new List<int>();

            // Act
            int big = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, big);
        }

        [Test]
        public void Test5()
        {
            // Act
            int big = Operations.Max(null);

            // Assert
            Assert.AreEqual(0, big);
        }
    }
}