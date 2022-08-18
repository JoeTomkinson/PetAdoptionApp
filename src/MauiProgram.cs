using CommunityToolkit.Maui;

namespace PetAdoptionApp;

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
                fonts.AddFont("Anja-Eliane.ttf", "AnjaEliane");
                fonts.AddFont("factory.ttf", "Factory");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
				fonts.AddFont("PoetsenOne-Regular.ttf", "PoetsenOne");
            });
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        return builder.Build();
	}
}