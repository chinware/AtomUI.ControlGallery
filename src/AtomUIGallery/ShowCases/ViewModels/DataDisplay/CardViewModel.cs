using Avalonia.Media;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CardViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Card";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;
    
    private IBrush? _borderlessFrameBg;

    public IBrush? BorderlessFrameBg
    {
        get => _borderlessFrameBg;
        set => this.RaiseAndSetIfChanged(ref _borderlessFrameBg, value);
    }
    
    private bool _isLoading;

    public bool IsLoading
    {
        get => _isLoading;
        set => this.RaiseAndSetIfChanged(ref _isLoading, value);
    }

    public CardViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}