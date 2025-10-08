using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class StepsViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Steps";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;
    
    private int _currentStep;

    public int CurrentStep
    {
        get => _currentStep;
        set
        {
            this.RaiseAndSetIfChanged(ref _currentStep, value);
            PreviousButtonVisible = CurrentStep > 0;
        }
    }

    private bool _previousButtonVisible;

    public bool PreviousButtonVisible
    {
        get => _previousButtonVisible;
        set => this.RaiseAndSetIfChanged(ref _previousButtonVisible, value);
    }
    
    public StepsViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}