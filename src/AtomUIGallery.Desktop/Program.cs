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
                    FontFallbacks = new[]
                    {
                        new FontFallback
                        {
                            FontFamily = new FontFamily("Microsoft YaHei")
                        }
                    }
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
        var builder = AppBuilder.Configure<GalleryApplication>()
                                .AfterSetup(builder =>
                                {
                                    builder.Instance!.Name = "AtomUIGallery";
                                })
                                .UseReactiveUI()
                                .UsePlatformDetect()
                                .With(new Win32PlatformOptions() { RenderingMode = [Win32RenderingMode.Software] })
                                .LogToTrace();
        
        var themeBuilder = builder.CreateThemeManagerBuilder();
        themeBuilder.UseCultureInfo(new CultureInfo(LanguageCode.en_US));
        themeBuilder.UseTheme(ThemeManager.DEFAULT_THEME_ID);
        themeBuilder.UseOSSControls();
        themeBuilder.UseOSSDataGrid();
        
        return builder.UseAtomUI(themeBuilder);
    }
}