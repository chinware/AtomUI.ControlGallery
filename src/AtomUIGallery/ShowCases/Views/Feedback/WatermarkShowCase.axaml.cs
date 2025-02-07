using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class WatermarkShowCase : ReactiveUserControl<WatermarkViewModel>
{
    public WatermarkShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}