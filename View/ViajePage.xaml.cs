using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;
using System.Text.Json;

namespace IscaCar.View;

public partial class ViajePage : ContentPage
{
	public ViajeVM vm { get; set; }
    private Viaje viaje;
	public ViajePage()
	{
		InitializeComponent();
		vm = new ViajeVM();
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

        await Shell.Current.GoToAsync($"{nameof(DetallViajePage)}",
            new Dictionary<string, object>
            {
                ["data"] = viaje
            });
    }

    protected override void OnAppearing()
    {
        vm.carregarDades();
        ItiListView.ItemsSource = vm.LViaj;
    }
}