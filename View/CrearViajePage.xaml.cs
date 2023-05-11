using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

public partial class CrearViajePage : ContentPage
{
	public CrearViajeVM vm;
	public CrearViajePage()
	{
		InitializeComponent();
		vm = new CrearViajeVM();
		BindingContext = vm;
	}
    private void continuar(object sender, EventArgs e)
    {
		continuarAsync();
    }
	private async Task continuarAsync()
	{
		vm.crearViaje();
		await Shell.Current.GoToAsync($"{nameof(CrearViajePage)}");
    }
}