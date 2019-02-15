using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestKøretøj
    {
        [TestMethod]
        public void NummerpladeSet_SetANummerplade_RetunsSetValue()
        {
            //Arrage
            Køretøj k = new Bil();
            string value = "AA92332";
            string expected = "AA92332";
            string actual = "";

            //Act
            k.Nummerplade = value;
            actual = k.Nummerplade;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NummerpladeSet_MoreThanAllowedChars_ThrowsException()
        {
            //Arrange
            Køretøj k = new Bil();

            //Act & Assert
            k.Nummerplade = "TK003004"; // Throws exception and therefor pass

            // Else fail
            Assert.Fail();
        }
    }
}
