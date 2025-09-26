using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmanaShop.DAL
{
    public  static class ServiceDalCollectionExtensions
    {

        public  static IServiceCollection AddDalServieces(this  IServiceCollection  services  , IConfiguration config)
        {

            services.AddDbContext<SamanDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("MyDb")));



            return services;

        }
    }
}
