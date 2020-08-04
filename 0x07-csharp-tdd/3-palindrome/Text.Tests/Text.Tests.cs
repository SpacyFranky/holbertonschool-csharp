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
            Assert.IsNull(null);
        }

        [Test]
        public void Test2()
        {
            string s = "";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Test3()
        {
            string s = "a";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Test4()
        {
            string s = "aba";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Test5()
        {
            string s = "levvel";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Test6()
        {
            string s = "le, v, .. e, l.";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Test7()
        {
            string s = "Le, v, .. e, l.";
            Assert.IsTrue(Str.IsPalindrome(s));
        }
    }
}