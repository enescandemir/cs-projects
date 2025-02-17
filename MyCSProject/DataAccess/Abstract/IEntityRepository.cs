using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic Constraint
    public interface IEntityRepository<T> where T : class,IEntity,new() // new(): IEntity interfacesinin implementesini engeller. New'lenebilir olmalı.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // LINQ kullanımı.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
