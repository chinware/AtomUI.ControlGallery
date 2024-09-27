using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class LoadingIndicatorShowCase : ReactiveUserControl<LoadingIndicatorShowCaseViewModel>
{
    public LoadingIndicatorShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}