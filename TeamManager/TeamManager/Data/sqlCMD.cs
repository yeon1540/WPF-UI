using System.Collections.Generic;
using System.Linq;

namespace TeamManager.Data
{
    public class sqlCMD
    {
        private readonly SqlManager _db;

        public sqlCMD(SqlManager context)
        {
            _db = context;
        }

        #region 삽입

        public bool Save<T>(T entity) where T : class
        {
            try
            {
                _db.Set<T>().Add(entity);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 조회

        protected T Get<T>(object key) where T : class
        {
            return _db.Set<T>().Find(key);
        }

        protected bool Update<T>(T entity) where T : class
        {
            try
            {
                _db.Set<T>().Attach(entity);
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected IList<T> GetList<T>() where T : class
        {
            return _db.Set<T>().ToList();
        }

        #endregion

        #region 삭제

        protected bool Delete<T>(T entity) where T : class
        {
            try
            {
                if (entity == null) return false;

                _db.Set<T>().Remove(entity);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
