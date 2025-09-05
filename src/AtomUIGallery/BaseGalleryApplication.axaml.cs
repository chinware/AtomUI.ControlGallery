using AtomUI;
using AtomUIGallery.ShowCases;
using AtomUIGallery.Workspace.Views;

namespace AtomUIGallery;

public partial class BaseGalleryAtomApplication : AtomApplication
{
    protected WorkspaceWindow CreateWorkspaceWindow()
    {
        return new WorkspaceWindow();
    }

    public override void RegisterServices()
    {
        base.RegisterServices();
        ShowCaseRegister.Register();
    }
}