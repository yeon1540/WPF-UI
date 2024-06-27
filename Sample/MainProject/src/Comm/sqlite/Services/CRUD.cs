using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using System.Collections.Generic;
using System.Linq;

namespace Comm.sqlite.Services
{
    public class CRUD<T> : IDataBase<T> where T : class
    {
        private readonly DefaultContext _dbContext;

        public CRUD(DefaultContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
