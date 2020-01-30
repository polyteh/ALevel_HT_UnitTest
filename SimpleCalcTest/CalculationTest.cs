using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcTest
{
    [TestClass]
    class CalculationTest
    {
        [TestMethod]
        public void Div_20_with_8_double_double()
        {
            // arrange
            double x = 20;
            double y = 8;
            double expected = 4.5;

            // act
            double actual = Calculation.Division(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Div_20_with_8_int_int()
        {
            // arrange
            int x = 20;
            int y = 8;
            double expected = 4.5;

            // act
            double actual = Calculation.Division(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
