using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class PopupConfirmShowCase : ReactiveUserControl<PopupConfirmShowCaseViewModel>
{
    public PopupConfirmShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}