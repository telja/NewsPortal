using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NewsPortal.DAL.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NewsPortalDbContext>
    {
        public NewsPortalDbContext CreateDbContext(string[] args)
        {
            // Kreiranje konfiguracije kako bi mogli dohvatiti Connection String iz appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<NewsPortalDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);

            return new NewsPortalDbContext(optionsBuilder.Options);
        }
    }
}
