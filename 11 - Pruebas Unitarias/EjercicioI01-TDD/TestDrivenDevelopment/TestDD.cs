using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestDrivenDevelopment
{
    [TestClass]
    public class TestDD
    {
        [TestMethod]
        //Given when then
        public void Add_CuandoRecibeUnStringVacio_DeberiaRetornar0()
        {
            //Arrange
            Calculadora calculadora = new Calculadora(); //instancia el objeto
            string texto = string.Empty;
            int expected = 0;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual); //verifica si son iguales
        }

        [TestMethod]
        //Given when then
        public void Add_CuandoRecibeUnNumero_DeberiaRetornarElNumero()
        {
            //Arrange
            Calculadora calculadora = new Calculadora(); //instancia el objeto
            string texto = "1";
            int expected = 1;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual); //verifica si son iguales
        }

        [TestMethod]        
        public void Add_CuandoRecibeDosNumerosSeparadosPorComa_DeberiaRetornarLaSuma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora(); 
            string texto = "1,2";
            int expected = 3;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void Add_CuandoRecibeCantidadDesconocidaDeNumerosSeparadosPorComa_DeberiaRetornarLaSuma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            string texto = "1,2,3,4";
            int expected = 10;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CuandoRecibeCantidadDesconocidaDeNumerosSeparadosPorComaYSlatoDeLinea_DeberiaRetornarLaSuma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            string texto = "1\n2,3,4";
            int expected = 10;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CuandoRecibeCantidadDesconocidaDeNumerosSeparadosPorDelimitadoresEspeciales_DeberiaRetornarLaSuma()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            string texto = "//:1\n2:3,4";
            int expected = 10;

            //Act
            int actual = calculadora.Add(texto);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_CuandoRecibeNumerosNegativos_DeberiaLanzarUnaException()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            string texto = "//:1\n2:-3,4";
            
            //Act
            int actual = calculadora.Add(texto);
                        
        }


    }
}
