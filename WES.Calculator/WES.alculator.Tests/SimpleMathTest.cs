using NUnit.Framework;
using System;


namespace WES.alculator.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [Test]
        public void IntergerDivision1()
        {
            //arrange
            SimpleMathTests math = new SimpleMathTests();
            //act
            int result = math.Divide(4, 2);
            //assert
            Assert.AreEqual(2, result);
        }

        [TestCase(4, 2, 2)]
        [TestCase(13, 6, 2)]
        [TestCase(-20, 5, -4)]
        public void IntegerDivision(int x, int y, int expected)
        {
            SimpleMath math = new SimpleMath();
            int actual = math.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideByZeroTest()
        {
            //arrange
            SimpleMathTests math = new SimpleMathTests();
            Assert.Throws<DivideByZeroException>(() => math.Divide(5, 0));
        }

        [SetUp]
        public void Init()
        {
            //run before every test
        }

        [TearDown]
        public void Cleanup()
        {
            //after test runner
        }


    }
}
