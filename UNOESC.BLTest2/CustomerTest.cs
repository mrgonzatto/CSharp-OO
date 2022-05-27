using Microsoft.VisualStudio.TestTools.UnitTesting;
using UNOESC.BL;

namespace UNOESC.BLTest2
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange - Carga dos valores do objeto
            Customer customer = new Customer(); // Instanciar o objeto
            customer.FirstName = "Mauricio";
            customer.LastName = "Gonzatto";

            string expected = "Gonzatto, Mauricio";

            //-- Act - Buscar a informação através do metodo ou propriedade programado
            string actual = customer.FullName;

            //-- Assert - Comparação entre o que está sendo passado e o que se espera
            Assert.AreEqual(expected, actual);
        }
    }
}
