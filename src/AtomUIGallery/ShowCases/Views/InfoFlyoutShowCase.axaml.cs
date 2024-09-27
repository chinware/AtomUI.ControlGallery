using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class InfoFlyoutShowCase : ReactiveUserControl<InfoFlyoutShowCaseViewModel>
{
    public InfoFlyoutShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}