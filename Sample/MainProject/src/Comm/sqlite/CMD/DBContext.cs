using Comm.sqlite.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Comm.sqlite.CMD
{
    public class DBContext
    {
        IServiceCollection _services;

        public IServiceCollection AddContext(IServiceCollection services)
        {
            try
            {
                _services = services.AddDbContext<DefaultContext>();
            }
            catch
            {
            }

            return _services;
        }

        public void SQLitePCLBatteriesInit()
        {
            SQLitePCL.Batteries.Init();
        }
    }
}
