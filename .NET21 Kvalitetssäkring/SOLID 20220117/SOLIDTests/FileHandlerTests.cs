using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Tests
{
    [TestClass()]
    public class FileHandlerTests
    {
        [TestMethod()]
        public void LoadTestFileDoesNotExist()
        {
            //Arrange
            var sut = new FileHandler() { FileName = "x:\\z.z" };

            //Act
            var actual = sut.Load();

            //Assert
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod()]
        public void LoadTestFileDoesExist()
        {
            var expected = "test";
            var fileName = "test.txt";
            File.WriteAllText(fileName, expected);
            //Arrange
            var sut = new FileHandler() { FileName = fileName };

            //Act
            var actual = sut.Load();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}