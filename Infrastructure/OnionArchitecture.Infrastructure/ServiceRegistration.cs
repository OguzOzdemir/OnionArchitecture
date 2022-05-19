using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
