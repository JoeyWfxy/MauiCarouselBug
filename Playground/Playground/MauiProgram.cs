using Microsoft.Extensions.Logging;
using Playground.Services;
using Playground.Models;
using Playground.ViewModels;
using Playground.Views;

namespace Playground;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<AnimalService>();
		builder.Services.AddSingleton<AnimalListView>();

		builder.Services.AddSingleton<AnimalListViewModel>();

		builder.Services.AddSingleton<IntroScreenView>();
		builder.Services.AddSingleton<IntroScreenViewModel>();
        builder.Services.AddSingleton<StudentListView>();
        builder.Services.AddSingleton<StudentListViewModel>();
        return builder.Build();
	}
}

