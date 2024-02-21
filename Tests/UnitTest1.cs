using TestProject1.Core;

namespace TestProject1.Tests
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test, Parallelizable]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test, Parallelizable]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}