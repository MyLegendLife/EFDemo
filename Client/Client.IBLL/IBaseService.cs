using Client.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.IBLL
{
    public interface IBaseService<T> where T : class,new()
    {
        IDBSession CurrentDBSession { get; }
        IDAL.IBaseDal<T> CurrentDal { get; set; }
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda);
        bool DeleteEntity(T entity);
        bool EditEntity(T entity);
        T AddEntity(T entity);
    }
}
