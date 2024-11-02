using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Application.Configer.contract.Interfac;
using MovieApp.Application.Configer.contract.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Configer
{
    public static class DepancyInJecation
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped< ImoveServies ,MovieServies>();

            return service;
        }
    }
}
