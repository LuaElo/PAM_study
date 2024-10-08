using PAMstudy.ViewModels;

namespace PAMstudy.Views;

public partial class MonitorView : ContentPage
{
	public MonitorView()
	{
		InitializeComponent();
		BindingContext = new MonitorViewModels();
	}
}