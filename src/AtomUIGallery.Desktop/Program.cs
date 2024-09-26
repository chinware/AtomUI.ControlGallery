using AtomUI.Icon;
using AtomUI.Icon.AntDesign;
using AtomUI.Theme;
using Avalonia;
using Avalonia.Media;
using Avalonia.ReactiveUI;
using Nlnet.Avalonia.DevTools;

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
#if DEBUG
            .UseDevToolsForAvalonia()
#endif
            .UseIconPackage<AntDesignIconPackage>(true)
            .With(new Win32PlatformOptions())
            .LogToTrace();
}