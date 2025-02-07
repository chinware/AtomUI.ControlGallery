using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class PaletteShowCase : ReactiveUserControl<PaletteShowCaseViewModel>
{
    public PaletteShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}