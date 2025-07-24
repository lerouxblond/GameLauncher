using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var relativePath = config["AppSettings:DatabaseRelativePath"];
            var absolutePath = Path.Combine(Directory.GetCurrentDirectory(), relativePath!);
            var connectionString = $"Data Source={absolutePath}";

            //Directory.CreateDirectory(Path.GetDirectoryName(absolutePath)!);

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new AppDbContext(config, optionsBuilder.Options);
        }
    }
}
