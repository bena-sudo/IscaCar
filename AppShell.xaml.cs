namespace IscaCar;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(View.NewPage1), typeof(View.NewPage1));
        Routing.RegisterRoute(nameof(View.InicioPage), typeof(View.InicioPage));
    }
}
