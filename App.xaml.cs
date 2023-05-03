using IscaCar.View;
namespace IscaCar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new InicioPage();
	}
}