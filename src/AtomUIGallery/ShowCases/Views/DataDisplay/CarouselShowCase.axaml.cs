using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CarouselShowCase : ReactiveUserControl<CarouselViewModel>
{
    public CarouselShowCase()
    {
        InitializeComponent();
    }
}