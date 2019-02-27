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
        [TestMethod]
        public void Pris_HarBrobizz_For5ProcentRabat()
        {
            //Arrange
            MC mc = new MC();
            mc.HasBrobizz = true;
            decimal expected = 118.75M;
            decimal actual = 0M;

            //Act
            actual = mc.Pris();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Pris_HarIkkeBrobizz_ForIkke5ProcentRabat()
        {
            //Arrange
            MC mc = new MC();
            mc.HasBrobizz = false;
            decimal expected = 125M;
            decimal actual = 0M;

            //Act
            actual = mc.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
