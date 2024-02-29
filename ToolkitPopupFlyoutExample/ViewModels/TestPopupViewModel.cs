using CommunityToolkit.Mvvm.ComponentModel;

namespace ToolkitPopupFlyoutExample.ViewModels;

public partial class TestPopupViewModel : BaseViewModel
{
	[ObservableProperty]
	public string labelMessage;

	public TestPopupViewModel()
	{
		LabelMessage = "Welcome to the Popup Test";
	}
}

