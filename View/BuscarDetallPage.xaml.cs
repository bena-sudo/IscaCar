using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

[QueryProperty(nameof(Viaje), "data")]
public partial class BuscarDetallPage : ContentPage
{
    private Viaje _viaje;
    public Viaje Viaje
    {
        get { return _viaje; }
        set
        {
            _viaje = value;
            vm.Viaje = value;
            BindingContext = vm;
        }
    }
    private BuscarDetallVM vm;
    public BuscarDetallPage()
    {
        InitializeComponent();
        vm = new BuscarDetallVM();
        
    }

    private void btCancelar(object sender, EventArgs e)
    {
        cambiarVistaAsync();
    }

    private async Task cambiarVistaAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(BuscarPage)}");
    }
}