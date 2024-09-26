using AtomUIGallery.Workspace.ViewModes;
using Avalonia.Controls;

namespace AtomUIGallery.Workspace.Views;

public partial class CaseNavigation : UserControl
{
    public CaseNavigation()
    {
        DataContext = new CaseNavigationViewModel();
        InitializeComponent();
    }
}