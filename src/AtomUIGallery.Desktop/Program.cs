using AtomUI.Theme;
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
        => AppBuilder.Configure<GalleryApplication>()
            .UseReactiveUI()
            .ConfigureAtomUI()
            .UsePlatformDetect()
            .UseAtomUI()
            .With(new Win32PlatformOptions())
            .LogToTrace();
}