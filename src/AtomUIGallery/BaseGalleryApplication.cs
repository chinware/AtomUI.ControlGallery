using AtomUIGallery.ShowCases;
using AtomUIGallery.Workspace.ViewModes;
using AtomUIGallery.Workspace.Views;
using Avalonia;

namespace AtomUIGallery;

public abstract class BaseGalleryApplication : Application
{
    protected WorkspaceWindow CreateWorkspaceWindow()
    {
        return new WorkspaceWindow()
        {
            DataContext = new WorkspaceWindowViewModel()
        };
    }

    public override void RegisterServices()
    {
        base.RegisterServices();
        ShowCaseRegister.Register();
    }
}