using AtomUI.Controls.Primitives;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class MenuShowCase : ReactiveUserControl<MenuViewModel>
{
    public MenuShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is MenuViewModel viewModel)
            {
                ChangeModeSwitch.IsCheckedChanged  += viewModel.HandleChangeModeCheckChanged;
                ChangeStyleSwitch.IsCheckedChanged += viewModel.HandleChangeStyleCheckChanged;
                var defaultOpenPaths = new List<TreeNodePath>();
                defaultOpenPaths.Add(new TreeNodePath("/3/SubGroup2"));
                viewModel.DefaultOpenPaths = defaultOpenPaths;
            }
        });
        InitializeComponent();
    }
}