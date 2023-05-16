using IscaCar.VM;

namespace IscaCar.View;

public partial class RegistrarPage : ContentPage
{
    public RegistrarVM vm;
	public RegistrarPage()
	{
		InitializeComponent();
        vm = new RegistrarVM();
        BindingContext = vm;
	}

    private void botCancelar(object sender, EventArgs e)
    {
        App.Current.MainPage = new InicioPage();
    }

    
    private void botRegistrar(object sender, EventArgs e)
    {
        registrarAsync();
    }

    private async Task registrarAsync()
    {
        await vm.AddUsuarioAsync(correo.Text, password.Text);
        App.Current.MainPage = new InicioPage();
    }
}