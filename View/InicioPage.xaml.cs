using IscaCar.Model;
using IscaCar.VM;
using IscaCar.Helpers;
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

    private void botIniciarSesion(object sender, EventArgs e)
    {
        iniciarSesionAsync();
    }
    private async Task iniciarSesionAsync()
    {
        Usuario usu = vm.BuscarUsusario(correo.Text, password.Text);
        if (usu != null)
        {
            Config.usuario = usu;
            App.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "¡El correo o la contraseña son incorrectas!", "Vale");
        }
    }

    private void botRegistrarse(object sender, EventArgs e)
    {
        App.Current.MainPage = new RegistrarPage();
    }
}