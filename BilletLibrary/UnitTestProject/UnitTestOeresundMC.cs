using Microsoft.VisualStudio.TestTools.UnitTesting;
using OeresundBilletLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestOeresundMC
    {
        [TestMethod]
        public void Pris_IngenBrobizz_PrisEr210()
        {
            //Arrange
            MC mc = new MC();
            decimal expected = 210;
            decimal actual = 0;

            //Act
            actual = mc.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pris_HarBrobizz_PrisEr73()
        {
            //Arrange
            MC mc = new MC();
            mc.HasBrobizz = true;
            decimal expected = 73;
            decimal actual = 0;

            //Act
            actual = mc.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KøretøjType_()
        {
            //Arrange
            MC mc = new MC();
            string expected = "Øresund MC";
            string actual = "";

            //Act
            actual = mc.KøretøjType();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}