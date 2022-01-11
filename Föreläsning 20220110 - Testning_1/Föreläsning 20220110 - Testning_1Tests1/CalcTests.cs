using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator;

namespace Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            //var testObject = Calc;
            var expected = 8;

            //Act
            var actual = Calc.Add(4, 4);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest_Sum16()
        {
            //Arrange
            //var testObject = new Calc();
            var expected = 16;

            //Act
            var actual = Calc.Add(8, 8);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class PhoneTests
    {
        [TestMethod()]
        public void VerifyPhoneNumberTest()
        {
            //Arrange
            var testObject = new VerifyStuff();
            var expected = true;
            var testData = "+";

            //Act
            var actual = testObject.VerifyPhoneNumber(testData);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}