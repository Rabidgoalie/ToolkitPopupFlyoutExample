using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToolkitPopupFlyoutExample.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly IPopupService _popupService;
    private int count = 0;

    [ObservableProperty]
    public string buttonText;

    public MainPageViewModel(IPopupService popupService)
    {
        ButtonText = "Click me";

        _popupService = popupService;
    }

    [RelayCommand]
	public void CounterClicked()
	{
        count++;

        if (count == 1)
            ButtonText = $"Clicked {count} time";
        else
            ButtonText = $"Clicked {count} times";

        SemanticScreenReader.Announce(ButtonText);
    }

    [RelayCommand]
    public async Task ShowPopup()
    {
        await _popupService.ShowPopupAsync<TestPopupViewModel>(onPresenting: vm =>
        {
            vm.Title = "Test Popup";
            vm.LabelMessage = "We are having problems with this Popup";
        });
    }
}

