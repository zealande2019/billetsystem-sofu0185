using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundBilletLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestOeresundBil
    {
        [TestMethod]
        public void Pris_IngenBrobizz_PrisEr410()
        {
            //Arrange
            Bil b = new Bil();
            decimal expected = 410;
            decimal actual = 0;
            
            //Act
            actual = b.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pris_HarBrobizz_PrisEr161()
        {
            //Arrange
            Bil b = new Bil();
            decimal expected = 161;
            decimal actual = 0;

            //Act
            actual = b.Pris(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KøretøjType()
        {
            //Arrange
            Bil b = new Bil();
            string expected = "Øresund Bil";
            string actual = "";

            //Act
            actual = b.KøretøjType();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
