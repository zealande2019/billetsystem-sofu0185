using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestBil
    {
        [TestMethod]
        public void Pris_ReturVærdi_Retunere240()
        {
            //Arrange
            Bil b = new Bil();
            decimal expected = 240;
            decimal actual = 0;

            //Act
            actual = b.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Køretøj_ReturVærdi_RetunereBil()
        {
            //Arrange
            Bil b = new Bil();
            string expected = "Bil";
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
            Bil b = new Bil();
            decimal expected = 228M;
            decimal actual = 0M;

            //Act
            actual = b.Pris(true);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Pris_HarIkkeBrobizz_ForIkke5ProcentRabat()
        {
            //Arrange
            Bil b = new Bil();
            decimal expected = 240M;
            decimal actual = 0M;

            //Act
            actual = b.Pris(false);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
