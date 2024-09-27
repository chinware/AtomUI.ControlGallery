using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ButtonSpinnerShowCase : ReactiveUserControl<ButtonSpinnerShowCaseViewModel>
{
    public ButtonSpinnerShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}