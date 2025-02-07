using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class BadgeShowCase : ReactiveUserControl<BadgeShowCaseViewModel>
{
    public BadgeShowCase()
    {
        InitializeComponent();
    }
}