﻿using Microsoft.Extensions.Logging;
using OOP2_FinalProject.Data;

namespace OOP2_FinalProject
{
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            var BookDBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BookDatabase.db");
            builder.Services.AddSingleton<BookService>(b => ActivatorUtilities.CreateInstance<BookService>(b, BookDBPath));

            var UserDBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDatabase.db");
            builder.Services.AddSingleton<UserService>(u => ActivatorUtilities.CreateInstance<UserService>(u, UserDBPath));

            return builder.Build();
        }
    }
}
