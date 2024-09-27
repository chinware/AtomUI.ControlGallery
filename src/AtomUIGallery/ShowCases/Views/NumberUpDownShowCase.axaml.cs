using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class NumberUpDownShowCase : ReactiveUserControl<NumberUpDownShowCaseViewModel>
{
    public NumberUpDownShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}