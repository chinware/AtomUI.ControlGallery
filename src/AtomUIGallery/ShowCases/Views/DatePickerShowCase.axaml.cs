using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DatePickerShowCase : ReactiveUserControl<DatePickerShowCaseViewModel>
{
    public DatePickerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}