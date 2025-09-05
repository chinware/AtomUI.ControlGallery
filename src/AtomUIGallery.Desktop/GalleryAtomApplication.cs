using Avalonia.Controls.ApplicationLifetimes;

namespace AtomUIGallery.Desktop;

public class GalleryAtomApplication : BaseGalleryAtomApplication
{
    public GalleryAtomApplication()
    {
        Name                  = "AtomUI Gallery";
    }
    
    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow       = CreateWorkspaceWindow();
                desktop.MainWindow.Title = Name;
                break;
            // case ISingleViewApplicationLifetime singleView:
            //     singleView.MainView = new MainView();
            //     break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}