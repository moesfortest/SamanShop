using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SamanShop.Bussiness;
using SmanaShop.DAL;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SamanShop.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var config = new ConfigurationBuilder()
           .SetBasePath(AppContext.BaseDirectory)
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();

            var services = new ServiceCollection();

            services.AddBussinessServices();

            services.AddDalservices(config);



            services.AddSingleton<MainViewModel>();

            services.AddSingleton<MainWindow>();

            ServiceProvider = services.BuildServiceProvider();



            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

        }
    }

}
