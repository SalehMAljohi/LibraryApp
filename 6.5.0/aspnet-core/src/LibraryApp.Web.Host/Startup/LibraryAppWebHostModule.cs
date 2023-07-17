using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryApp.Configuration;

namespace LibraryApp.Web.Host.Startup
{
    [DependsOn(
       typeof(LibraryAppWebCoreModule))]
    public class LibraryAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryAppWebHostModule).GetAssembly());
        }
    }
}
