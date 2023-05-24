using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

[QueryProperty(nameof(Viaje), "data")]
public partial class DetallViajePage : ContentPage
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
    private DetallViajeVM vm;
    public DetallViajePage()
    {
        InitializeComponent();
        vm = new DetallViajeVM();
    }


    private void btCancelar(object sender, EventArgs e)
    {
        cambiarVistaAsync();
    }

    private async Task cambiarVistaAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(ViajePage)}");
    }

    private void btBorrar(object sender, EventArgs e)
    {
        borrarAsync();
    }

    private async Task borrarAsync()
    {
        bool answer = await DisplayAlert("Atencion", "Quieres borrar el viaje?", "Si", "No");

        if (answer)
        {
            vm.deleteViaje();
            await Shell.Current.GoToAsync($"{nameof(ViajePage)}");
        }
    }
}