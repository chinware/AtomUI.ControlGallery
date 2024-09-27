using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TooltipShowCase : ReactiveUserControl<TooltipShowCaseViewModel>
{
    public TooltipShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}