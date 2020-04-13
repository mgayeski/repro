using NUnit.Framework;

namespace testdemo
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    [TestFixture(typeof(int))]
    [TestFixture(typeof(string))]
    public class TypedParameter<T>
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.True(typeof(T) == typeof(int) || typeof(T) == typeof(string));
        }
    }
}