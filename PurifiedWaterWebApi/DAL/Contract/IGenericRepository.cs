using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PurifiedWaterWebApi.DAL.Contract
{
    public interface IGenericRepository : IDisposable
    {
        T Add<T>(T t) where T : class;
        T Update<T>(T t, Object key) where T : class;
        void Delete<T>(T entity) where T : class;
        IQueryable<T> FindBy<T>(Expression<Func<T, bool>> predicate) where T : class;
        List<T> GetAll<T>() where T : class;
        T Get<T>(int id) where T : class;
    }
}
