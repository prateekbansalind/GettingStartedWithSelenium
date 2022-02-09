using NUnit.Framework;

namespace SeleniumLearning
{
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
            TestContext.Progress.WriteLine("Test setup execution");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is Test1.");
        }

        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("This is Test2.");
        }

        [TearDown]
        public void ClosedBrowser()
        {
            TestContext.Progress.WriteLine("Test Ended.");
        }
    }
}