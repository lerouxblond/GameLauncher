using GameLauncher.Data;
using GameLauncher.Helpers;
using GameLauncher.Services.Auth;
using GameLauncher.Views.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows.Forms;

namespace GameLauncher;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Charger configuration (ex: appsettings.json)
        var builder = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                // Config de EF Core
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlite(context.Configuration.GetConnectionString("DefaultConnection")));

                // Services
                services.AddScoped<IAppDbContextFactory, DbContextFactory>();
                services.AddScoped<AuthService>();

                // Lancer l'app sur AuthMainView
                services.AddTransient<AuthMainView>();
            });

        var host = builder.Build();

        ApplicationConfiguration.Initialize();
        var mainForm = host.Services.GetRequiredService<AuthMainView>();
        Application.Run(mainForm);
    }    
}