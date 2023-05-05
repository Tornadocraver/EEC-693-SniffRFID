using Microsoft.Extensions.Logging;
#if ANDROID
using SniffRFID.Platforms.Android;
#endif

namespace SniffRFID;

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

// ** CODE BELOW DID NOT WORK, BUT LEFT IN FOR FUTURE REFERENCE ** \\
//
//#if ANDROID
//		builder.Services.AddSingleton<MainPage>();
//		builder.Services.AddTransient<IService, EmulatorService>();
//#endif

		return builder.Build();
	}
}
