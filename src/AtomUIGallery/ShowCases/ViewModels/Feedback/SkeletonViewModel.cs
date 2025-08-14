using AtomUI;
using AtomUI.Controls;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SkeletonViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SkeletonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private bool _isSkeletonActive;

    public bool IsSkeletonActive
    {
        get => _isSkeletonActive;
        set => this.RaiseAndSetIfChanged(ref _isSkeletonActive, value);
    }
    
    private bool _isSkeletonBlock;

    public bool IsSkeletonBlock
    {
        get => _isSkeletonBlock;
        set => this.RaiseAndSetIfChanged(ref _isSkeletonBlock, value);
    }
    
    private SizeType _skeletonButtonAndInputSizeType;

    public SizeType SkeletonButtonAndInputSizeType
    {
        get => _skeletonButtonAndInputSizeType;
        set => this.RaiseAndSetIfChanged(ref _skeletonButtonAndInputSizeType, value);
    }

    private SkeletonButtonShape _skeletonButtonShape;

    public SkeletonButtonShape SkeletonButtonShape
    {
        get => _skeletonButtonShape;
        set => this.RaiseAndSetIfChanged(ref _skeletonButtonShape, value);
    }
    
    
    private AvatarShape _skeletonAvatarShape;

    public AvatarShape SkeletonAvatarShape
    {
        get => _skeletonAvatarShape;
        set => this.RaiseAndSetIfChanged(ref _skeletonAvatarShape, value);
    }
    
    private bool _skeletonLoading;

    public bool SkeletonLoading
    {
        get => _skeletonLoading;
        set => this.RaiseAndSetIfChanged(ref _skeletonLoading, value);
    }

    public SkeletonViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}