using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ExpanderShowCase : ReactiveUserControl<ExpanderShowCaseViewModel>
{
    public ExpanderShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is ExpanderShowCaseViewModel viewModel)
            {
                ExpandButtonPosGroup.OptionCheckedChanged       += viewModel.HandleExpandButtonPosOptionCheckedChanged;
                ExpandDirectionOptionGroup.OptionCheckedChanged += viewModel.HandleExpandDirectionOptionCheckedChanged;
            }
        });
        InitializeComponent();
    }
}