using CoreImage;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

public partial class ViajePage : ContentPage
{
	public ViajeVM vm { get; set; }
	public ViajePage()
	{
		InitializeComponent();
		vm = new ViajeVM();
		BindingContext = vm;
	}

    private void itemPulsado(object sender, ItemTappedEventArgs e)
    {
		Viaje v = (Viaje)e.Item;
		abrirVentanaAsync(v);
    }
	public async Task abrirVentanaAsync(Viaje v)
	{
        await Shell.Current.GoToAsync($"{nameof(DetallViajePage)}?{nameof(DetallViajePage.VM.Viaje)}={v}");
    }
}