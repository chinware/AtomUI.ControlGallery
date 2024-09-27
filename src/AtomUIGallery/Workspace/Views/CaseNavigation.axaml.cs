using AtomUI.Controls;
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
        ShowCaseNavMenu.NavMenuItemClick += HandleNavMenuItemClick;
    }

    private void HandleNavMenuItemClick(object? sender, NavMenuItemClickEventArgs args)
    {
        Console.WriteLine(args.NavMenuItem.ItemKey);
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