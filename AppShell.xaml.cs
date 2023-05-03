using IscaCar.Model;

namespace IscaCar;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(View.PerfilPage), typeof(View.PerfilPage));
    }
}
