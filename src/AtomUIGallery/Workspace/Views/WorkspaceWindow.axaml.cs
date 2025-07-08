using AtomUI.ReactiveUI;
using AtomUIGallery.Workspace.ViewModes;
using Avalonia;

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

    public override void Show()
    {
        base.Show();
        Height    = double.NaN;
        Width     = double.NaN;
    }
}