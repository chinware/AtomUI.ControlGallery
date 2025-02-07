using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ExpanderShowCase : ReactiveUserControl<ExpanderViewModel>
{
    public ExpanderShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is ExpanderViewModel viewModel)
            {
                ExpandButtonPosGroup.OptionCheckedChanged       += viewModel.HandleExpandButtonPosOptionCheckedChanged;
                ExpandDirectionOptionGroup.OptionCheckedChanged += viewModel.HandleExpandDirectionOptionCheckedChanged;
            }
        });
        InitializeComponent();
    }
}