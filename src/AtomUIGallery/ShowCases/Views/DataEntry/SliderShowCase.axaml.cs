using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class SliderShowCase : ReactiveUserControl<SliderShowCaseViewModel>
{
    
    
    public SliderShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}