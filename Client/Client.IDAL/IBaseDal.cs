using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.IDAL
{
    public interface IBaseDal<T> where T : class,new()
    {
        T AddEntity(T entity);
        bool DeleteEntity(T entity);
        bool EditEntity(T entity);
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda);
    }
}
