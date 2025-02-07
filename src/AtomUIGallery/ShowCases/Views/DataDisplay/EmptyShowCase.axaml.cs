using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class EmptyShowCase : ReactiveUserControl<EmptyViewModel>
{
    public EmptyShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}