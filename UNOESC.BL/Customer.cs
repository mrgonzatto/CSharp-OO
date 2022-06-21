

using System.Collections.Generic;

namespace UNOESC.BL
{
    public class Customer
    {

        //-----------------------------
        // Snippet construtor = ctor + tab
        
        // O construtor sem parâmetros nós chamamos de default
        public Customer() : this(0)
        {            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;            
        }

        public Customer(int customerId, string firstName)
        {
            CustomerId = customerId;
            FirstName = firstName;            
        }

        public Customer(
            int customerId, 
            string emailAddres, 
            string firstName, 
            string lastName, 
            IEnumerable<CustomerAddress> customerAddresses
        ) : this(customerId, emailAddres)
        {
            FirstName = firstName;            
            LastName = lastName;
            CustomerAddresses = customerAddresses;
        }



        //-----------------------------


        //-----------------------------

        // O VS possui alguns atalhos que chamamos de Snippets
        // atalho para criar atributos prop + tab

        // -----------------
        // Formas de encapsulamento com getters e setters
        public int CustomerId { get; private set; }

        // Propriedade auto-implementada
        public string EmailAddres { get; set; }
        public string FirstName { get; set; }        

        // Propriedade do C#
        private string _lastName;        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; } 
        }

        public string FullName
        {
            // Apenas get = readonly
            get
            {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }        
                
        
        public IEnumerable<CustomerAddress> CustomerAddresses { get; set; }
            = new List<CustomerAddress>();
        // -----------------
        
        /// <summary>
        /// Validação dos dados do cliente
        /// </summary>
        /// <returns>É Válido?</returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddres)) isValid = false;

            return isValid;

        }

        //------------------
    }
}
