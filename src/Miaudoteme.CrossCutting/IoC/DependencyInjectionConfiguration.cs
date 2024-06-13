using Miaudoteme.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.CrossCutting.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddInfraestruturaApi(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefautConnection"));
            });



            return services;
        }

    }
}
