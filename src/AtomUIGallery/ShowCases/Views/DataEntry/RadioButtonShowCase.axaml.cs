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
    
    public void ToggleDisabledStatus(object arg)
    {
        ToggleDisabledRadioUnChecked.IsEnabled = !ToggleDisabledRadioUnChecked.IsEnabled;
        ToggleDisabledRadioChecked.IsEnabled   = !ToggleDisabledRadioChecked.IsEnabled;
    }
}