using Abstraction;
using Microsoft.Extensions.Logging;
using ViewModels;

namespace MauiDotNet8
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
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

      builder.Services.AddSingleton<IDialogService, DialogService>(); 
      builder.Services.AddTransient<MainPageViewModel>();
      builder.Services.AddTransient<MainPage>(); 

#if DEBUG
  		builder.Logging.AddDebug();
#endif

      return builder.Build();
    }
  }
}
