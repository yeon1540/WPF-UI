using Comm.sqlite.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Comm.sqlite.CMD
{
    public class DBContext
    {
        ServiceCollection services = new ServiceCollection();

        public bool AddContext()
        {
            bool result = false;

            try
            {
                services.AddDbContext<DefaultContext>();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
