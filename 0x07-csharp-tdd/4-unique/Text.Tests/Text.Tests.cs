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
        public void Test1()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, Str.UniqueChar("abcda"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(0, Str.UniqueChar("abcd"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbbccdd"));
        }
    }
}