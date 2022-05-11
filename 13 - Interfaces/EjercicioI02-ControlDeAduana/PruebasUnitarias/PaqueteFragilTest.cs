using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace PruebasUnitarias
{
    [TestClass]
    public class PaqueteFragilTest
    {
       [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange: Inicializar las variables
            decimal costo = 100M;
            PaqueteFragil paquete = new PaqueteFragil("F01", costo, "Buenos aires", "La rioja", 1);

            //Act: llamar al metodo testear
            decimal cobrar = paquete.AplicarImpuestos();
            //Asset: Comprobar el valor con lo esperado
            Assert.AreEqual(135, cobrar);
        }
       
        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorCientoSobreCostoEnvio()
        {
            //Arrange: Inicializar las variables
            decimal costo = 100M;
            PaqueteFragil paquete = new PaqueteFragil("F01", costo, "Buenos aires", "La rioja", 1);
            decimal impuesto;

            //Act: llamar al metodo testear
            impuesto = paquete.Impuestos;
            //Asset: Comprobar el valor con lo esperado
            Assert.AreEqual(35, impuesto);
        }
       
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange: Inicializar las variables
            bool respuesta;
            PaqueteFragil paquete = new PaqueteFragil("F01", 190.00M, "Buenos aires", "La rioja", 1.75);
            
            //Act: llamar al metodo testear
            respuesta = paquete.TienePrioridad;
            
            //Asset: Comprobar el valor con lo esperado
            Assert.IsTrue(respuesta);
        }

    }

}
