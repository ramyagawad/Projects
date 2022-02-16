using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WES.Calculator.BLL;

namespace WES.Calculator.Test
{
    public class Calculator
    {
        [Test]
        public void IntergerDivision1()
        {
            //arrange
            SimpleMath math = new SimpleMath();
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
            SimpleMath math = new SimpleMath();
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



