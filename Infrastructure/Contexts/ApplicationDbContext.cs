using Microsoft.EntityFrameworkCore;
using webapiTercero.Dommain.Entities;

namespace webapiTercero.Infrastructure.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customer {get; set;}
    }
}