using CommunityToolkit.Maui;
using PetAdoptionApp.Contracts.Abstracts;
using PetAdoptionApp.Contracts.Services;
using PetAdoptionApp.Services;
using PetAdoptionApp.ViewModels;
using PetAdoptionApp.Views;

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

        builder = ConfigureServices(builder);
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        return builder.Build();
    }

    /// <summary>
    /// Configure DI Services
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    internal static MauiAppBuilder ConfigureServices(MauiAppBuilder builder)
    {
        // View Model and Pages
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<PetsMainPage>();
        builder.Services.AddSingleton<PetsMainViewModel>();
        builder.Services.AddSingleton<PetDetailsPage>();
        builder.Services.AddTransient<PetDetailsViewModel>();
        builder.Services.AddSingleton<FavouritePetsPage>();
        builder.Services.AddTransient<FavouritePetsViewModel>();
        builder.Services.AddSingleton<PetsLocationPage>();
        builder.Services.AddTransient<PetsLocationViewModel>();
        builder.Services.AddSingleton<MaintenancePage>();
        builder.Services.AddTransient<MaintenanceViewModel>();

        // Services
        builder.Services.AddSingleton<IDialogService, ModalDialogService>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<BasePetService, PetService>();
        return builder;
    }
}