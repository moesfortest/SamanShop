using Microsoft.Extensions.DependencyInjection;
using SamanShop.Bussiness.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness
{
    public static class BussinessServiceRegisterServices
    {
        public static IServiceCollection AddBussinessServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductServices>();
            return services;
        }
    }
}
