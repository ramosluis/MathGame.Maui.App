﻿using MathGame.Maui.Data;

namespace MathGame.Maui;

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
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "db");

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<GameRepository>(s, dbPath));

        return builder.Build();
    }
}
