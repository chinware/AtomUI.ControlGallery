using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CarouselViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Carousel";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    public CarouselViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}