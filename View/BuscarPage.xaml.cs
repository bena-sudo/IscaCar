using IscaCar.VM;

namespace IscaCar.View;

public partial class BuscarPage : ContentPage
{
	public BuscarVM vm;
	public BuscarPage()
	{
		InitializeComponent();
		vm = new BuscarVM();
		BindingContext = vm;
	}

    private void buscar(object sender, EventArgs e)
    {
        buscarAsync();
    }
	private async Task buscarAsync()
	{
        if (vm.PobLlegada == null || vm.PobSalida == null)
		{
            await DisplayAlert("Error", "¡Debe de introducir una poblacion!", "Vale");
        }
		else
		{
            if (vm.buscar())
            {
                await Shell.Current.GoToAsync($"{nameof(LlistaBuscarPage)}");
            }
            else
            {
                await DisplayAlert("Not Found", "¡No se ha encontrado ningun resultado!", "Vale");
            }
        }
    }
}