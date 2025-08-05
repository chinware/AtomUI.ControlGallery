using System.Globalization;
using AtomUI.Controls;
using AtomUI.Theme;
using AtomUI.Utils;
using Avalonia;
using Avalonia.Media;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.Desktop;

internal class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        try
        {
            BuildAvaloniaApp()
                .With(new FontManagerOptions
                {
                    FontFallbacks = [new FontFallback
                    {
                        FontFamily = new FontFamily("Microsoft YaHei")
                    }]
                })
                .StartWithClassicDesktopLifetime(args);
        }
        catch (Exception ex)
        {
            File.WriteAllText("error.log", ex.ToString());
#if DEBUG
            throw;
#endif
        }
    }

    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<GalleryApplication>()
                                .UseReactiveUI()
                                .UsePlatformDetect()
                                .With(new Win32PlatformOptions())
                                .UseAtomUI(builder =>
                                {
                                    builder.WithDefaultCultureInfo(new CultureInfo(LanguageCode.en_US));
                                    builder.WithDefaultTheme(IThemeManager.DEFAULT_THEME_ID);
                                    builder.UseOSSControls();
                                    builder.UseOSSDataGrid();
                                })
                                .LogToTrace();
        
    }
}