using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnionArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<OnionArchitectureDbContext>(options => options.UseSqlServer(@"Data Source=.;Initial Catalog=OnionArchitectureDb;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=1234"));
        }
    }
}
