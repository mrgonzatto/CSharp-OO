using System.Collections.Generic;

namespace UNOESC.BL
{
    public class CustomerRepository
    {        

        public Customer Retrieve(int customerId)
        {
            /* Lógica de consulta do consumidor com o
             * código especificado */
            return new Customer(1, "Mauricio");

            //return new Customer();
        }

        public List<Customer> Retrieve()
        {
            List<Customer> consumidores = 
                new List<Customer>();

            Customer c1 = new Customer { 
                FirstName = "Gustavo",
                LastName = "Calegari"
            };

            Customer c2 = new Customer { 
                FirstName = "Mauricio",
                LastName = "Gonzatto"
            };

            consumidores.Add(c1);
            consumidores.Add(c2);

            return consumidores;
        }
    }
}
