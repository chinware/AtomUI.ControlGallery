using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class AlertShowCase : ReactiveUserControl<AlertViewModel>
{
    public AlertShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}