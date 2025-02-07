using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CheckBoxShowCase : ReactiveUserControl<CheckBoxViewModel>
{
    public CheckBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}