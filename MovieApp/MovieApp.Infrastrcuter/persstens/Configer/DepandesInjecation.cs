using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Infrastrcuter.persstens.Configer
{
    public static class DepandesInjecation
    {
        public static IServiceCollection AddInfrastarcterServices(this IServiceCollection service , IConfiguration configuration)
        {
            return service;
        }

        public static WebApplication UseInfrastracterServiec(this WebApplication app)
        {
            return app;
        }
    }
}
