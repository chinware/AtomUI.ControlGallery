using AtomUI;
using AtomUI.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ButtonViewModel : ReactiveObject, IRoutableViewModel, IActivatableViewModel
{
    public const string ID = "Button";

    public IScreen HostScreen { get; }
    public ViewModelActivator Activator { get; }

    public string UrlPathSegment { get; } = ID;

    private SizeType _buttonSizeType;

    public SizeType ButtonSizeType
    {
        get => _buttonSizeType;
        set => this.RaiseAndSetIfChanged(ref _buttonSizeType, value);
    }

    public ButtonViewModel(IScreen screen)
    {
        Activator  = new ViewModelActivator();
        HostScreen = screen;
    }
}