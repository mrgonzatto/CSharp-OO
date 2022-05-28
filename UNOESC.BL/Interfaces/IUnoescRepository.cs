using System.Linq;

namespace UNOESC.BL.Interfaces
{
    public interface IUnoescRepository
    {
        IQueryable<Customer> Customers { get; }

        void SaveCustomer( Customer c );
        void CreateCustomer( Customer c );
        void DeleteCustomer(Customer c);
    }
}
