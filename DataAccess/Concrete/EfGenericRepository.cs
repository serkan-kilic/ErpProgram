using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        public EfGenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            // EF Core'un belleğinde kalan eski nesne takiplerini temizliyoruz
            _context.ChangeTracker.Clear();

            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            // EF Core'un belleğinde kalan eski nesne takiplerini temizliyoruz
            _context.ChangeTracker.Clear();

            if (entity is ISoftDeletable sd)
            {
                sd.deleted = "d";
                _context.Set<T>().Update(entity);
            }
            else
            {
                _context.Set<T>().Remove(entity);
            }
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            // EF Core'un belleğinde kalan eski nesne takiplerini temizliyoruz
            _context.ChangeTracker.Clear();

            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

    }
}
