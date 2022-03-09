using System.Linq.Expressions;
using webapiTercero.Dommain.Entities;

namespace webapiTercero.Application.Interfaces.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int Id);
        IEnumerable<Customer> Find(Expression<Func<Customer,bool>> expression);
        bool Exist(int Id);
        int Count(Customer entity);
        void Add(Customer entity);
        void AddRange(IEnumerable<Customer> entities);
        void Update(int Id,Customer entity);
        void Remove(int Id);
        void Remove(Customer entity);
        void RemoveRange(IEnumerable<Customer> entities);
    }
}