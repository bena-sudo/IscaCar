using IscaCar.VM;

namespace IscaCar.View;

public partial class DetallViajePage : ContentPage
{
	private DetallViajeVM VM { get; set; }
    public DetallViajePage()
	{
		InitializeComponent();
		VM = new DetallViajeVM();
		BindingContext = VM;
	}
}