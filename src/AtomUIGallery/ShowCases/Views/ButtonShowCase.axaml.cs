using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ButtonShowCase : ReactiveUserControl<ButtonShowCaseViewModel>
{
    public ButtonShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}