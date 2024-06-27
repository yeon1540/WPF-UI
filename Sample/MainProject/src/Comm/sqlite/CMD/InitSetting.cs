using Comm.sqlite.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Comm.sqlite.CMD
{
    public class InitSetting
    {
        IServiceCollection _services;

        /// <summary>
        /// DB Context파일 등록 명령어
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceCollection AddContext(IServiceCollection services)
        {
            try
            {
                //DB 등록
                _services = services.AddDbContext<DefaultContext>();
            }
            catch
            {
            }

            return _services;
        }

        /// <summary>
        /// sqlite 초기화 명령어
        /// </summary>
        public void SQLitePCLBatteriesInit()
        {
            SQLitePCL.Batteries.Init();
        }
    }
}
