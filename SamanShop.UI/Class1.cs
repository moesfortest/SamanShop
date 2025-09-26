//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Configuration;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Windows;

//namespace SamanShop.UI
//{
//    public partial class App : Application
//    {
//        public static IServiceProvider ServiceProvider { get; private set; }

//        protected override void OnStartup(StartupEventArgs e)
//        {
//            base.OnStartup(e);

//            // 1️⃣ Build configuration
//            var configuration = new ConfigurationBuilder()
//                .SetBasePath(AppContext.BaseDirectory)
//                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                .Build();

//         
//            var services = new ServiceCollection();

//            // Register DbContext
//            services.AddDbContext<SamanShop.DAL.AppDbContext>(options =>
//                options.UseSqlServer(configuration.GetConnectionString("MyDb")));

//          
//            services.AddTransient<ICustomerService, CustomerService>();

//           
//            services.AddSingleton<MainViewModel>();

//           
//            services.AddSingleton<MainWindow>();

//            ServiceProvider = services.BuildServiceProvider();

//          
//            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
//            mainWindow.Show();
//        }
//    }
//}
