using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ToolkitPopupFlyoutExample.Popups;
using ToolkitPopupFlyoutExample.ViewModels;

namespace ToolkitPopupFlyoutExample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
            // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();

		builder.Services.AddTransientPopup<TestPopup, TestPopupViewModel>();

		return builder.Build();
	}
}

