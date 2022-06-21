using Microsoft.EntityFrameworkCore;
using UNOESC.BL;

namespace UNOESCWeb.Models
{
    public class UNOESCDbContext : DbContext
    {
        public UNOESCDbContext(DbContextOptions<UNOESCDbContext> options) 
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        
        // aqui eu configuro as outras entidades para mapear no BD
    }
}
