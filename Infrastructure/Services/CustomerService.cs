using System.Linq.Expressions;
using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Application.Interfaces.Services;
using webapiTercero.Dommain.Entities;

namespace webapiTercero.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;

        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ILogger<CustomerService> logger,
                                IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            
        }

        public void Add(Customer entity)
        {
            _unitOfWork.Customers.Add(entity);
            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public int Count(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _unitOfWork.Customers.GetAll();
        }

        public Customer GetById(int Id)
        {
            return _unitOfWork.Customers.GetById(Id);
        }

        public void Remove(int Id)
        {
            _unitOfWork.Customers.Remove(Id);
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Customer> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Customer entity)
        {
            _unitOfWork.Customers.Update(Id,entity);
            _unitOfWork.Complete();
        }
    }
}