using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewTech.Core.Interface;

namespace NewTech.Core.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly NewTechDbContext _context;

        public Repository(NewTechDbContext context)
        {
            _context = context;
        }

        protected void Save() => _context.SaveChanges();
        public int Count(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).Count();
        }

        public void Create(T entity)
        {
            _context.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            //_context.Remove(entity);
            //Save();

            if (entity != null)
            {
                Task t = Task.Run(() =>
                {
                    _context.Remove(entity);
                    Save();
                });
                t.Wait();
            }
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }
}
