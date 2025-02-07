using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CalendarShowCase : ReactiveUserControl<CalendarShowCaseViewModel>
{
    public CalendarShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}