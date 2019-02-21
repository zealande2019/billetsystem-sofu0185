using System;
using StoreBaeltBilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestStoreBaeltBil
    {
        [DataTestMethod]
        [DataRow(2)] //Lørdag
        [DataRow(3)] //Søndag
        public void Pris_HarIkkeBrobzzKryderIWeekenden_PrisMedWeekendsRabat(int value)
        {
            //Arrange
            Bil b = new Bil("Hej", new DateTime(2019, 2, value));
            decimal expected = 192;
            decimal actual = 0;
            //Act
            actual = b.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1)] //Fredag
        [DataRow(4)] //Mandag
        public void Pris_HarIkkeBrobzzKryderIkkeIWeekenden_PrisUdenWeekendsRabat(int value)
        {
            //Arrange
            Bil b = new Bil("Hej", new DateTime(2019, 2, value));
            decimal expected = 240;
            decimal actual = 0;
            //Act
            actual = b.Pris();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(2)] //Lørdag
        [DataRow(3)] //Søndag
        public void Pris_HarBrobzzKryderIWeekenden_PrisMedWeekendsOgBrobizzRabat(int value)
        {
            //Arrange
            Bil b = new Bil("Hej", new DateTime(2019, 2, value));
            decimal expected = 182.4M;
            decimal actual = 0M;
            //Act
            actual = b.Pris(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1)] //Fredag
        [DataRow(4)] //Mandag
        public void Pris_HarBrobzzKryderIkkeIWeekenden_PrisUdenWeekendsMenMedBrobizzRabat(int value)
        {
            //Arrange
            Bil b = new Bil("Hej", new DateTime(2019, 2, value));
            decimal expected = 228;
            decimal actual = 0;
            //Act
            actual = b.Pris(true);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
