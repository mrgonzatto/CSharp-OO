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

            //-- Act - Buscar a informa��o atrav�s do metodo ou propriedade programado
            string actual = customer.FullName;

            //-- Assert - Compara��o entre o que est� sendo passado e o que se espera
            Assert.AreEqual(expected, actual);
        }
    }
}
