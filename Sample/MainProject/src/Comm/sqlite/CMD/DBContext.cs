using Comm.sqlite.Interfaces;
using Comm.sqlite.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

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
