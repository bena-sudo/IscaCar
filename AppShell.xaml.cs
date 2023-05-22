using IscaCar.Model;

namespace IscaCar;

public partial class AppShell : Shell
{

    public AppShell()
    {
		InitializeComponent();
        
        Routing.RegisterRoute(nameof(View.CrearViajePage), typeof(View.CrearViajePage));
        
        Routing.RegisterRoute(nameof(View.ViajePage), typeof(View.ViajePage));
        Routing.RegisterRoute(nameof(View.DetallViajePage), typeof(View.DetallViajePage));

        Routing.RegisterRoute(nameof(View.PerfilPage), typeof(View.PerfilPage));

        Routing.RegisterRoute(nameof(View.BuscarPage), typeof(View.BuscarPage));
        Routing.RegisterRoute(nameof(View.LlistaBuscarPage), typeof(View.LlistaBuscarPage));
        Routing.RegisterRoute(nameof(View.BuscarDetallPage), typeof(View.BuscarDetallPage));
    }
}
