using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SamanShop.Bussiness;
using SmanaShop.DAL.Repositories;
using System.Runtime.CompilerServices;

namespace SmanaShop.DAL
{
    public static class DataLayerRegisterDependency
    {

        public static  IServiceCollection  AddDalservices(this IServiceCollection services,  IConfiguration config)
        {
            services.AddDbContext<SamanDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("MyDb")));

            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
