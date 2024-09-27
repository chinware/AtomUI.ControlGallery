using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TimePickerShowCase : ReactiveUserControl<TimePickerShowCaseViewModel>
{
    public TimePickerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}