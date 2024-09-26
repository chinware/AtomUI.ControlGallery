using Avalonia.Controls.ApplicationLifetimes;

namespace AtomUIGallery.Desktop;

public class GalleryApplication : BaseGalleryApplication
{
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