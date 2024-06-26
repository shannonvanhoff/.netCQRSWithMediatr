using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cleanarchicqrswithmediator.infra
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfraServices (this IServiceCollection services, IConfiguration iconnfiguration)
        {
            return services;
        }
    }
}
