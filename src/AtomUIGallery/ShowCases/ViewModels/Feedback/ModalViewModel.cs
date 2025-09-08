using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ModalViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Modal";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private bool _isBasicModalOpened;

    public bool IsBasicModalOpened
    {
        get => _isBasicModalOpened;
        set => this.RaiseAndSetIfChanged(ref _isBasicModalOpened, value);
    }

    public ModalViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}