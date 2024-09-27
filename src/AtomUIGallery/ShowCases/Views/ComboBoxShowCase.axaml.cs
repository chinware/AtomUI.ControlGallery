using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ComboBoxShowCase : ReactiveUserControl<ComboBoxShowCaseViewModel>
{
    public ComboBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}