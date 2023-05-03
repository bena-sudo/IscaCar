using IscaCar.VM;

namespace IscaCar.View;

public partial class PerfilPage : ContentPage
{
	public PerfilVM vm { get; set; }

	public PerfilPage()
	{
		InitializeComponent();
		vm = new PerfilVM();
		BindingContext = vm;
	}
}