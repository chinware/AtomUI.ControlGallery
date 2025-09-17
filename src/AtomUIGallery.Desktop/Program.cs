using AtomUI.Controls;
using AtomUI.Theme;
using AtomUI.Theme.Language;
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
            LogException(ex);
#if DEBUG
            throw;
#endif
        }
    }

    private static void LogException(Exception ex)
    {
        try
        {
            var homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            
            var logDirectory = Path.Combine(homeDirectory, Path.Combine("AtomUIGallery", "AppCrashLogs"));
            Directory.CreateDirectory(logDirectory);
            
            var logFileName = $"CrashLog_{DateTime.Now:yyyyMMdd_HHmmss}.log";
            var logFilePath = Path.Combine(logDirectory, logFileName);
            
            File.WriteAllText(logFilePath, 
                $"CrashTime: {DateTime.Now}\r\n" +
                $"Exception Type: {ex.GetType().Name}\r\n" +
                $"Exception Message: {ex.Message}\r\n" +
                $"Stack Info: \r\n{ex.StackTrace}");
        }
        catch
        {
#if DEBUG
            throw;
#endif
        }
    }
    

    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<GalleryAtomApplication>()
                                .UseReactiveUI()
                                .UsePlatformDetect()
                                .With(new Win32PlatformOptions())
                                .UseAtomUI(builder =>
                                {
                                    builder.WithDefaultLanguageVariant(LanguageVariant.zh_CN);
                                    builder.WithDefaultTheme(IThemeManager.DEFAULT_THEME_ID);
                                    builder.UseOSSControls();
                                    builder.UseGalleryControls();
                                    builder.UseOSSDataGrid();
                                    builder.UseColorPicker();
                                })
                                .LogToTrace();
        
    }
}