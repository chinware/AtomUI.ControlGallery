using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SkeletonShowCase : ReactiveUserControl<SkeletonViewModel>
{
    public SkeletonShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}