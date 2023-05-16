using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

[QueryProperty(nameof(Viaje), "data")]
public partial class DetallViajePage : ContentPage
{
    private Viaje _viajes;
    public Viaje Viajes
    {
        get { return _viajes; }
        set
        {
            _viajes = value;
            vm.Viaje = value;
        }
    }
    private DetallViajeVM vm;
    public DetallViajePage()
    {
        InitializeComponent();
        vm = new DetallViajeVM();
        vm.Viaje = Config.Viaje;
        BindingContext = vm;
    }


    private void btCancelar(object sender, EventArgs e)
    {
        cambiarVistaAsync();
    }

    private async Task cambiarVistaAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(ViajePage)}");
    }
}