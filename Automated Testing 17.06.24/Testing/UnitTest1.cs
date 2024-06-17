using Automated_Testing_17._06._24;

namespace Testing
{
    public class Tests
    {
        Calculator myCalculator;
        [SetUp]
        public void Setup()
        {
            myCalculator = new Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.That(myCalculator.Add(2, 2).Equals(4));
        }

        [Test]
        public void Test2()
        {
            Assert.That(myCalculator.Subtract(6, 2).Equals(4));
        }

        [Test]
        public void Test3()
        {
            Assert.That(myCalculator.Multiply(3, 2).Equals(6));
        }

        [Test]
        public void Test4()
        {
            Assert.That(myCalculator.Divide(6, 2).Equals(3));
        }
    }
}