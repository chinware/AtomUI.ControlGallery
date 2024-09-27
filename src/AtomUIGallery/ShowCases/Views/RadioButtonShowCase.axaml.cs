using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class RadioButtonShowCase : ReactiveUserControl<RadioButtonShowCaseViewModel>
{
    public RadioButtonShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}