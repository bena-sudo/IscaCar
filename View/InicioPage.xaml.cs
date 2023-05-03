using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

public partial class InicioPage : ContentPage
{
    private InicioVM vm;

	public InicioPage()
	{
		InitializeComponent();
        vm = new InicioVM();
        BindingContext = vm;
	}

    private void iniciarSesion(object sender, EventArgs e)
    {
        iniciarSesionAsync();
    }
    private async Task iniciarSesionAsync()
    {
        Usuario usuario = new Usuario();
        usuario.Correo = correo.Text;
        usuario.Password = password.Text;

        vm.Usuario = usuario;
        if (vm.Iniciar())
        {
            App.Current.MainPage = new AppShell();
            //await Shell.Current.GoToAsync($"{nameof(PrincipalPage)}?{nameof(PrincipalPage.Usuario)}={vm.Usuario}");
        }
        else
        {
            await DisplayAlert("Error", "¡El correo o la contraseña son incorrectas!", "Vale");
        }
    }

    private void registrarse(object sender, EventArgs e)
    {
        App.Current.MainPage = new RegistrarPage();
    }
}