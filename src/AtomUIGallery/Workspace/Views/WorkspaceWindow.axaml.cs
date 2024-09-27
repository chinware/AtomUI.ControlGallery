using AtomUIGallery.Workspace.ViewModes;
using Avalonia;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.Workspace.Views;

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public WorkspaceWindow()
    {
#if DEBUG
        this.AttachDevTools();
#endif
        DataContext = new WorkspaceWindowViewModel();
        InitializeComponent();
    }
}