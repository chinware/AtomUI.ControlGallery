using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class BadgeShowCase : ReactiveUserControl<BadgeShowCaseViewModel>
{
    public BadgeShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}