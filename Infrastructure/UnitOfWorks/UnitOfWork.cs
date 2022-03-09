using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Infrastructure.Contexts;

namespace webapiTercero.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly ApplicationDbContext _context;
        public ICustomerRepository Customers {get;}

        
        public UnitOfWork(ApplicationDbContext context,
                         ICustomerRepository customers)
        {
            _context = context;
            Customers = customers;
        }

        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}