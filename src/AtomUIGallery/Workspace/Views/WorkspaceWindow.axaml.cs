using AtomUIGallery.Workspace.ViewModes;
using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.Workspace.Views;

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    
    public WorkspaceWindow()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
}