using AtomUIGallery.Workspace.ViewModes;
using Avalonia;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.Workspace.Views;

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public WorkspaceWindow()
    {
        DataContext = new WorkspaceWindowViewModel();
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
}