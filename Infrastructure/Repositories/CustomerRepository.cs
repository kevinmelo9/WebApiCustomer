using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Dommain.Entities;
using webapiTercero.Infrastructure.Contexts;

namespace webapiTercero.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}