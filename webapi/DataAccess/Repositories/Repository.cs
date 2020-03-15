using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapi.DataAccess.Entities;
using System.Data.Entity;

namespace webapi.DataAccess.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {
        private StatsDbContext _context;

        protected Repository(StatsDbContext context)
        {
            _context = context;
        }

        public virtual int Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            return _context.SaveChanges();
        }

        public virtual List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public virtual T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();

            return obj;
        }
    }
}