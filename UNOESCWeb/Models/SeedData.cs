using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using UNOESC.BL;

namespace UNOESCWeb.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated( IApplicationBuilder app )
        {
            UNOESCDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<UNOESCDbContext>();

            if ( context.Database.GetPendingMigrations().Any() )
            {
                context.Database.Migrate();
            }

            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer
                    {
                        EmailAddres = "mauricio.gonzatto@unoesc.edu.br",
                        FirstName = "Mauricio", LastName = "Gonzatto"                        
                    },
                    new Customer { 
                        EmailAddres = "alysson.oliveira@unoesc.edu.br", 
                        FirstName = "Alysson", LastName = "Oliveira"
                    }
                );
                context.SaveChanges();
            }

        }

    }
}
