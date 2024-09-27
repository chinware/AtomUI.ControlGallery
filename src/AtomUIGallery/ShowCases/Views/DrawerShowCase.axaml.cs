using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DrawerShowCase : ReactiveUserControl<DrawerShowCaseViewModel>
{
    public DrawerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}