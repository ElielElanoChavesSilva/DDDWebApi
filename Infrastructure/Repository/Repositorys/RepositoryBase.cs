using Domain.Core.Interfaces.Repositorys;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Repository.Repositorys
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext Context)
        {
            _context = Context;
        }

        public virtual void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();

        }

        public virtual TEntity? GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Remove(TEntity obj)
        {

            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

    }
}