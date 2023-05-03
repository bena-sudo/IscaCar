using IscaCar.VM;

namespace IscaCar.View;

public partial class BuscarPage : ContentPage
{
	public BuscarVM vm { get; set; }
	public BuscarPage()
	{
		InitializeComponent();
		vm = new BuscarVM();
		BindingContext = vm;
	}

    private void buscar(object sender, EventArgs e)
    {

    }
}