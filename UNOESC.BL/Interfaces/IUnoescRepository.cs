using System.Linq;

namespace UNOESC.BL.Interfaces
{
    public interface IUnoescRepository
    {
        IQueryable<Customer> Customers { get; }
    }
}
