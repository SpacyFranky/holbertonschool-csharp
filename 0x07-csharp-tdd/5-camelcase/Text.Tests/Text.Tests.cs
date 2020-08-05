using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(2, Str.CamelCase("helloThere"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(1, Str.CamelCase("hellothere"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(2, Str.CamelCase("hellothereFriend"));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual(4, Str.CamelCase("helloThereFriendHowdy"));
        }
    }
}