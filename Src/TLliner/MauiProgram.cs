using TLiner.Domain.Abstractions.Services;
using TLliner.DependencyInjection;

namespace TLliner;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.Services.AddConfiguration(FileSystem.Current.AppDataDirectory);
        builder.Services.AddServices();
        builder.Services.AddRepositories();
        builder.Services.AddTransient(s => new MainPage(s.GetService<ITLinerService>()));

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}