using CommunityToolkit.Maui.Views;
using ToolkitPopupFlyoutExample.ViewModels;

namespace ToolkitPopupFlyoutExample.Popups;

public partial class TestPopup : Popup
{
	public TestPopup(TestPopupViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}

	async void Button_Clicked(System.Object sender, System.EventArgs e) => await CloseAsync();
}
