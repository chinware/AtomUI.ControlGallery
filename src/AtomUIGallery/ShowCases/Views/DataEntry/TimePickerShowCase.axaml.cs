using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TimePickerShowCase : ReactiveUserControl<TimePickerViewModel>
{
    public TimePickerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}