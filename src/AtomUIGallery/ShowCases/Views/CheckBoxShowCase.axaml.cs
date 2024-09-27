using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CheckBoxShowCase : ReactiveUserControl<CheckBoxShowCaseViewModel>
{
    public CheckBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}