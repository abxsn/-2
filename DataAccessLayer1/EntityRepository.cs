using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Entity;
using LogicToData;
namespace DataAccessLayer1
{
    public class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        private DBContext _context;
        public EntityRepository(DBContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ToDelete = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(ToDelete);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T ReadById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
        public int Count()
        {
            return _context.Set<T>().Count();
        }
    }
}
