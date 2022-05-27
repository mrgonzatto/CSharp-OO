using System.Linq;
using UNOESC.BL;
using UNOESC.BL.Interfaces;

namespace UNOESCWeb.Models.EF
{
    public class EFUnoescRepository : IUnoescRepository
    {
        private UNOESCDbContext context;

        public EFUnoescRepository(UNOESCDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Customer> Customers => context.Customers;
    }
}
