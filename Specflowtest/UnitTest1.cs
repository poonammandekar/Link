namespace Specflowtest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Hello");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}