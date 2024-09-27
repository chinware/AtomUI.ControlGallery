using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CollapseShowCase : ReactiveUserControl<CollapseShowCaseViewModel>
{
    public CollapseShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}