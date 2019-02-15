using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestMC
    {
        [TestMethod]
        public void Pris_ReturVærdi_Retunere125()
        {
            //Arrange
            MC b = new MC();
            decimal expected = 125;
            decimal actual = 0;

            //Act
            actual = b.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Køretøj_ReturVærdi_RetunereMC()
        {
            //Arrange
            MC b = new MC();
            string expected = "MC";
            string actual = "";

            //Act
            actual = b.KøretøjType();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
