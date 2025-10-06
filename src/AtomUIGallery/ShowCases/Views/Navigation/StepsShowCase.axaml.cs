using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class StepsShowCase : ReactiveUserControl<StepsViewModel>
{
    public StepsShowCase()
    {
        InitializeComponent();
    }
}