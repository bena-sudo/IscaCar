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
}