using Microsoft.Extensions.Logging;

namespace LocalizationRecipe;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().RegisterServices();

        return builder.Build();
    }

    private static MauiAppBuilder RegisterServices(
        this MauiAppBuilder mauiAppBuilder
    )
    {
        mauiAppBuilder.Services.AddLocalization();
        mauiAppBuilder.Services.AddLogging();
        return mauiAppBuilder;
    }
}
