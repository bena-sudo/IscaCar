using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

public partial class LlistaBuscarPage : ContentPage
{
    public LlistaBuscarVM vm { get; set; }
    private Viaje viaje { get; set; }
    public LlistaBuscarPage()
    {
        InitializeComponent();
        vm = new LlistaBuscarVM();
        BindingContext = vm;
    }

    private void itemPulsado(object sender, ItemTappedEventArgs e)
    {
        viaje = (Viaje)e.Item;
        Config.Viaje = viaje;
        abrirVentanaAsync();
    }

    public async Task abrirVentanaAsync()
    {

        await Shell.Current.GoToAsync($"{nameof(BuscarDetallPage)}",
            new Dictionary<string, object>
            {
                ["data"] = viaje
            });
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