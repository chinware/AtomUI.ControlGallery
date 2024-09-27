using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class AlertShowCase : ReactiveUserControl<AlertShowCaseViewModel>
{
    public AlertShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}