using PurifiedWaterWebApi.Context;
using PurifiedWaterWebApi.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PurifiedWaterWebApi.DAL
{
    public class GenericRepository : IGenericRepository
    {
        private ApplicationDbContext _context;

        public void Dispose()
        {
            if (_context != null)
                _context = null;
        }

        public virtual T Add<T>(T t) where T : class
        {
            #region Add
            _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
            #endregion
        }

        public virtual T Update<T>(T t, object key) where T : class
        {
            #region Update
            if (t == null)
                return null;
            T exist = _context.Set<T>().Find(key);
            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(t);
                _context.SaveChanges();
            }
            return exist;
            #endregion
        }

        public virtual void Delete<T>(T entity) where T : class
        {
            #region Delete
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            #endregion
        }

        public List<T> GetAll<T>() where T : class
        {
            #region GetAll
            return _context.Set<T>().ToList();
            #endregion
        }

        public virtual IQueryable<T> FindBy<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            #region FindBy
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
            #endregion
        }

        public virtual T Get<T>(int id)where T: class
        {
            #region Get
            return _context.Set<T>().Find(id);
            #endregion
        }
    }
}
