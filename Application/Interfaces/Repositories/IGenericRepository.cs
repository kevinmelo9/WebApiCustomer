using System.Linq.Expressions;

namespace webapiTercero.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        IEnumerable<T> Find(Expression<Func<T,bool>> expression);
        bool Exist(int Id);
        int Count(T entity);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(int Id,T entity);
        void Remove(int Id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}