using IscaCar.DAO;
using IscaCar.Model;
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

    private void cancelar(object sender, EventArgs e)
    {
        App.Current.MainPage = new InicioPage();
    }

    
    private void registrarse(object sender, EventArgs e)
    {
        registrarseAsync();
    }

    private async Task registrarseAsync()
    {
        Usuario u = new Usuario();
        u.Correo = correo.Text;
        u.Password = password.Text;
        await UsuarioDAO.AddUsuario(u);
        App.Current.MainPage = new InicioPage();
    }
}