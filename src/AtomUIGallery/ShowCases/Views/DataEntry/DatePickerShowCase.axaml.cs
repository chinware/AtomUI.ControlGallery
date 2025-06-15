using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DatePickerShowCase : ReactiveUserControl<DatePickerViewModel>
{
    public DatePickerShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is DatePickerViewModel viewModel)
            {
                // PickerSizeTypeOptionGroup.OptionCheckedChanged  += viewModel.HandlePickerSizeTypeOptionCheckedChanged;
                // PickerPlacementOptionGroup.OptionCheckedChanged += viewModel.HandlePickerPlacementCheckedChanged;
            }
        });
        InitializeComponent();
    }
}