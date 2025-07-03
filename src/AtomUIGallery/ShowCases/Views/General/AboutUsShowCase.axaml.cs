using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class AboutUsShowCase : ReactiveUserControl<AboutUsViewModel>
{
    public AboutUsShowCase()
    {
        this.WhenActivated(disposables =>
        {
           
        });
        InitializeComponent();
    }
}