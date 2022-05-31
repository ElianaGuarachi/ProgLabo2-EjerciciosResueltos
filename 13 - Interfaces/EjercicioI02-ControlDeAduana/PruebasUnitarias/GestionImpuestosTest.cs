using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            decimal valorEsperado = 105;
            List<Paquete> paquetes = new List<Paquete>();
            PaqueteFragil pf = new PaqueteFragil("1111", 100M,"prueba","prueba",1);
            PaquetePesado pf2 = new PaquetePesado("2222", 200M,"prueba","prueba",2);
            paquetes.Add(pf);
            paquetes.Add(pf2);

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            //Act
            decimal valorRetorno = gestionImpuestos.CalcularTotalImpuestosAduana();

            //Asset
            Assert.AreEqual(valorRetorno, valorEsperado);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            decimal valorEsperado = 50;
            List<Paquete> paquetes = new List<Paquete>();
            PaqueteFragil pf = new PaqueteFragil("1111", 100M, "prueba", "prueba", 1);
            PaquetePesado pf2 = new PaquetePesado("2222", 200M, "prueba", "prueba", 2);
            paquetes.Add(pf);
            paquetes.Add(pf2);

            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            //Act
            decimal valorRetorno = gestionImpuestos.CalcularTotalImpuestosAfip();

            //Asset
            Assert.AreEqual(valorRetorno, valorEsperado);
        }


    }
}
