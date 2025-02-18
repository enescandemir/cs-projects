using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> // bir entity ve bir context alarak evrenselleşti.
        where TEntity : class,IEntity, new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // Direkt o veriye git ama yoksa oluştur.
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() // Filter null ise entity tablosuna yerlesip tüm tabloyu listeye çevir.
                    : context.Set<TEntity>().Where(filter).ToList(); // Filtre uygula.
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // Direkt o veriye git ama yoksa oluştur.
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
