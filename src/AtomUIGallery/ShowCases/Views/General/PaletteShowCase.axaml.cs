using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class PaletteShowCase : ReactiveUserControl<PaletteViewModel>
{
    public PaletteShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}