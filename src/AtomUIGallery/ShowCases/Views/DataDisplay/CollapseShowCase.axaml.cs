using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CollapseShowCase : ReactiveUserControl<CollapseViewModel>
{
    public CollapseShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is CollapseViewModel viewModel)
            {
                ExpandButtonPosGroup.OptionCheckedChanged += viewModel.HandleExpandButtonPosOptionCheckedChanged;
            }
        });
        InitializeComponent();
    }
}