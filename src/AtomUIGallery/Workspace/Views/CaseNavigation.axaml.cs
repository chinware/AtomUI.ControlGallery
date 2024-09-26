using AtomUIGallery.Workspace.ViewModes;
using Avalonia.Controls;
using Avalonia.LogicalTree;
using ReactiveUI;

namespace AtomUIGallery.Workspace.Views;

public partial class CaseNavigation : UserControl
{
    public CaseNavigation()
    {
        InitializeComponent();
    }

    protected override void OnAttachedToLogicalTree(LogicalTreeAttachmentEventArgs e)
    {
        base.OnAttachedToLogicalTree(e);
        if (DataContext is null)
        {
            var current = Parent;
            while (current is not null)
            {
                if (current.DataContext is IScreen screen)
                {
                    DataContext = new CaseNavigationViewModel(screen);
                }
                current = current.Parent;
            }
        }
    }
}