
using System.ComponentModel.DataAnnotations;

namespace UNOESC.BL
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public Address()
        {

        }

        public Address(int id)
        {
            this.Id = id;
        }

        public bool Validate()
        {
            bool retorno = true;

            if (string.IsNullOrWhiteSpace(Street)) retorno = false;
            if (string.IsNullOrWhiteSpace(District)) retorno = false;
            if (string.IsNullOrWhiteSpace(City)) retorno = false;
            if (string.IsNullOrWhiteSpace(Country)) retorno = false;
            if (string.IsNullOrWhiteSpace(ZipCode)) retorno = false;

            return retorno;
        }

    }
}
