using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class IconShowCase : ReactiveUserControl<IconViewModel>
{
    public IconShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}