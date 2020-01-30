using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    [TestClass]
    class EmailCheckerTest
    {
        [TestMethod]
        public void TestLenghtBelow4()
        {
            // arrange
            string email = "foo";
            bool expected = false;

        // act
            bool actual = EmailChecker.CheckEmail(email);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTwoAdressSign()
        {
            // arrange
            string email = "foo@sfs@";
            bool expected = false;

            // act
            bool actual = EmailChecker.CheckEmail(email);

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void TestWrongAdressSignPosition()
        {
            // arrange
            string email = "foo@blablacom";
            bool expected = false;

            // act
            bool actual = EmailChecker.CheckEmail(email);

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void TestUa()
        {
            // arrange
            string email = "myEmail@ua";
            bool expected = true;

            // act
            bool actual = EmailChecker.CheckEmail(email);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
