using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SeparatorShowCase : ReactiveUserControl<SeparatorViewModel>
{
    public SeparatorShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}