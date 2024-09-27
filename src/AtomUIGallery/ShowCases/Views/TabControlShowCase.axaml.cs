using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TabControlShowCase : ReactiveUserControl<TabControlShowCaseViewModel>
{
    public TabControlShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}