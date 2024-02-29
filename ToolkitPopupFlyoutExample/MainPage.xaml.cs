using ToolkitPopupFlyoutExample.ViewModels;

namespace ToolkitPopupFlyoutExample;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}


