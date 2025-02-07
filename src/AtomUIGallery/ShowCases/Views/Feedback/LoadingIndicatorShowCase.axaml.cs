using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class LoadingIndicatorShowCase : ReactiveUserControl<LoadingIndicatorViewModel>
{
 
    public LoadingIndicatorShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}