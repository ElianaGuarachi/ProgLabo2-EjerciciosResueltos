using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;

namespace TestMetodoFizzBuzz
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        public void FizzBuzz_CuandoEsDivisibleSoloPor3_DeberiaRetornarFizz()
        {
            //Arrange
            int num = 12; //entero que va a invocar al metodo;
            string expected = "Fizz"; //string esperado

            //Act
            string actual = num.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisibleSoloPor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int num = 5;
            string expected = "Buzz";

            //Act
            string actual = num.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoNoEsDivisibleSPorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int num = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = num.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(2,"2")] //van a ser mis parametros
        [DataRow(4,"4")]
        [DataRow(1,"1")]
        public void FizzBuzz_CuandoNoEsDivisiblePor3o5_DeberiaRetornarElNumero(int n, string expected)
        {
            //Arrange
            //Tengo parametros que uso, esta parte no es necesario

            //Act
            string actual = n.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);

        }



    }
}
