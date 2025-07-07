using AtomUI.ReactiveUI;
using AtomUIGallery.Workspace.ViewModes;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;

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

        LayoutUpdated += (sender, args) =>
        {
            var screen = Screens.Primary;
            if (screen != null)
            {
                Position = new PixelPoint(
                    (int)((screen.Bounds.Width - DesiredSize.Width * RenderScaling) / 2),
                    (int)((screen.Bounds.Height - DesiredSize.Width * RenderScaling) / 2)
                );
            }
        };
    }
}