using Microsoft.Extensions.Logging;
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
            var LibDBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LibraryDatabase.db");
            builder.Services.AddSingleton<LibraryService>(b => ActivatorUtilities.CreateInstance<LibraryService>(b, LibDBPath));

            //var UserDBPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDatabase.db");
            //builder.Services.AddSingleton<UserService>(u => ActivatorUtilities.CreateInstance<UserService>(u, UserDBPath));

            return builder.Build();
        }
    }
}
