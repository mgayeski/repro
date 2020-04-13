using NUnit.Framework;

namespace testdemo
{
    [TestFixture]
    public class UntypedTestFixture
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.True(!string.IsNullOrEmpty(default(double).ToString()));
        }

        [Test]
        public void Test2()
        {
            Assert.True(!string.IsNullOrEmpty(default(int).ToString()));
        }
    }

    [TestFixture(typeof(int))]
    [TestFixture(typeof(double))]
    public class TypedTestFixture<T>
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.True(!string.IsNullOrEmpty(default(T).ToString()));
        }
    }
}