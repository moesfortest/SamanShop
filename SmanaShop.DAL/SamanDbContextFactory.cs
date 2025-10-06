using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace SmanaShop.DAL
{

    namespace MyApp.DAL
    {
        public class SamanDbContextFactory : IDesignTimeDbContextFactory<SamanDbContext>
        {
            public SamanDbContext CreateDbContext(string[] args)
            {
                // EF Core tools run here, current directory will be the UI project's output
                string basePath = Directory.GetCurrentDirectory(); // Points to WPF UI bin folder

                var config = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connStr = config.GetConnectionString("MyDb");

                var optionsBuilder = new DbContextOptionsBuilder<SamanDbContext>();
                optionsBuilder.UseSqlServer(connStr);

                return new SamanDbContext(optionsBuilder.Options);
            }
        }
    }

}
