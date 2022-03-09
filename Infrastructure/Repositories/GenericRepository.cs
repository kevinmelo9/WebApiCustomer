using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using webapiTercero.Application.Interfaces.Repositories;
using webapiTercero.Infrastructure.Contexts;

namespace webapiTercero.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            EntityEntry entry = _context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State =EntityState.Added;
            }
            else
            {
                _context.Set<T>().Add(entity);
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public int Count(T entity)
        {
            return _context.Set<T>().Count();
        }

        public bool Exist(int Id)
        {
            try 
            {
                var type = typeof(T);
                var entity = _context.Set<T>().Find(Id);
                return (entity != null) ? true:false;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return  _context.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public void Remove(int Id)
        {
            _context.Set<T>().Remove(_context.Set<T>().Find(Id));
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(int Id, T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}