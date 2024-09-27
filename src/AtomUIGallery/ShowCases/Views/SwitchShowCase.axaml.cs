using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SwitchShowCase : ReactiveUserControl<SwitchShowCaseViewModel>
{
    public SwitchShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}