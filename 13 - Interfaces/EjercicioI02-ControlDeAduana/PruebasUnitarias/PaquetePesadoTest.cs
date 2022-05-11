using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace PruebasUnitarias
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            //Arrange
            PaquetePesado paquete = new PaquetePesado("F01", 100.00M, "Buenos aires", "La rioja", 1.75);

            //Act
            decimal cobrar = paquete.AplicarImpuestos();

            //Asset
            Assert.AreEqual(160.00M, cobrar);
        }
        
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorCientoSobreCostoEnvio_CuandoEsImplementacionEsplicitaIAfip()
        {
            //Arrange
            PaquetePesado paquete = new PaquetePesado("F01", 100.00M, "Buenos aires", "La rioja", 1.75);

            //Act
            decimal impuesto = ((IAfip)paquete).Impuestos;

            //Asset
            Assert.AreEqual(25.00M, impuesto);
        }
        
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorCientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //Arrange
            PaquetePesado paquete = new PaquetePesado("F01", 190.00M, "Buenos aires", "La rioja", 1.75);
            decimal impuesto;

            //Act
            impuesto = paquete.Impuestos;

            //Asset
            Assert.AreEqual(66.5M, impuesto);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange: Inicializar las variables
            bool respuesta;
            PaquetePesado paquete = new PaquetePesado("P01", 2598.63M, "Misiones", "San luis", 56.32);

            //Act: llamar al metodo testear
            respuesta = paquete.TienePrioridad;

            //Asset: Comprobar el valor con lo esperado
            Assert.IsFalse(respuesta);
        }

    }
}
