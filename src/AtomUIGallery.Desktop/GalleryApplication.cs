using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Styling;
using Avalonia.Threading;

namespace AtomUIGallery.Desktop;

public class GalleryApplication : BaseGalleryApplication
{
    public GalleryApplication()
    {
        RequestedThemeVariant = ThemeVariant.Light;
    }
    
    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = CreateWorkspaceWindow();
                break;
            // case ISingleViewApplicationLifetime singleView:
            //     singleView.MainView = new MainView();
            //     break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}