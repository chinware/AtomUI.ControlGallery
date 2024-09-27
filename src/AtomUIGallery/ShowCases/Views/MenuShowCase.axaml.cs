using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class MenuShowCase : ReactiveUserControl<MenuShowCaseViewModel>
{
    public MenuShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}