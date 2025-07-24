using GameLauncher.Controllers.Auth;
using GameLauncher.Services;
using GameLauncher.Views.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace GameLauncher;

public partial class MainView : Form
{
    private readonly IServiceProvider _provider;
    public MainView( IServiceProvider provider)
    {
        _provider = provider;
        InitializeComponent();
    }

    private void LogoutButton_Click(object sender, EventArgs e)
    {
        var authPage = _provider.GetRequiredService<AuthMainView>();
        Hide();
        _provider.GetRequiredService<SessionService>().ClearSession();
        authPage.Show();
    }
}
