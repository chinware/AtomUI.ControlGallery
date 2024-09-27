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
        if (DataContext is CaseNavigationViewModel caseNavigationViewModel)
        {
            var showCaseId = args.NavMenuItem.ItemKey;
            if (showCaseId is null)
            {
                // TODO 是不是可以跳转到默认的 ShowCase 页面
                return;
            }
            caseNavigationViewModel.NavigateTo(showCaseId);
        }
    }

    protected override void OnAttachedToLogicalTree(LogicalTreeAttachmentEventArgs e)
    {
        base.OnAttachedToLogicalTree(e);
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