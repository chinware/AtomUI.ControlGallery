using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ColorPickerViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ColorPicker";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ColorPickerViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}