using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;

namespace CompanyProject.Config
{
    public class SqlManager
    {
        public IDataBase<Eqpinfo> Eqpinfo { get; set; }
    }
}