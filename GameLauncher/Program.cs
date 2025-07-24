using GameLauncher.Controllers.Auth;
using GameLauncher.Data;
using GameLauncher.Helpers;
using GameLauncher.Services;
using GameLauncher.Services.Auth;
using GameLauncher.Views.Auth;
using GameLauncher.Views.Auth.Control;
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
                var relativePath = context.Configuration["AppSettings:DatabaseRelativePath"];
                var absolutePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath!);
                var connectionString = $"Data Source={absolutePath}";
                Console.WriteLine($"DB folder verified: {connectionString}");



                // Config de EF Core
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlite(connectionString));

                // Services
                services.AddScoped<AuthService>();
                services.AddScoped<AuthController>();
                services.AddScoped<SessionService>();

                // view & forms
                services.AddTransient<AuthMainView>();
                services.AddTransient<MainView>();

                // UserControls
                services.AddTransient<LoginControl>();
                services.AddTransient<RegisterControl>();

            });

        var host = builder.Build();
        

        ApplicationConfiguration.Initialize();

        var sessionService = host.Services.GetRequiredService<SessionService>();
        var session = sessionService.LoadSession();

        Form mainForm;
        if (session != null && session.StaySignedIn)
            mainForm = host.Services.GetRequiredService<MainView>();
        else
            mainForm = host.Services.GetRequiredService<AuthMainView>();

        Application.Run(mainForm);
    }    
}