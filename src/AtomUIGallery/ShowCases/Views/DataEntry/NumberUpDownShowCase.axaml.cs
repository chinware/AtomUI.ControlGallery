using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class NumberUpDownShowCase : ReactiveUserControl<NumberUpDownViewModel>
{
    public NumberUpDownShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}