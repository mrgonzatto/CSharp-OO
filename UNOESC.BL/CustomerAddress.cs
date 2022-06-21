using System;
using System.Collections.Generic;
using System.Text;

namespace UNOESC.BL
{
    public class CustomerAddress
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

    }
}
