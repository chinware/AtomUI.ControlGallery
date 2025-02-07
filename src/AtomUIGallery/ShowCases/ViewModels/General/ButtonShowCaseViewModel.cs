using AtomUI;
using AtomUI.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ButtonShowCaseViewModel : ReactiveObject, 
                                       IRoutableViewModel,
                                       IActivatableViewModel
{
    public const string ID = "ButtonShowCase";
    
    public IScreen HostScreen { get; }
    public ViewModelActivator Activator { get; }
    
    public string UrlPathSegment { get; } = ID;

    private SizeType _buttonSizeType;

    public SizeType ButtonSizeType
    {
        get => _buttonSizeType;
        set => this.RaiseAndSetIfChanged(ref _buttonSizeType, value);
    }

    public ButtonShowCaseViewModel(IScreen screen)
    {
        Activator  = new ViewModelActivator();
        HostScreen = screen;
    }
    
    public void HandleButtonSizeTypeOptionCheckedChanged(object? sender, OptionCheckedChangedEventArgs args)
    {
        if (args.Index == 0)
        {
            ButtonSizeType = SizeType.Large;
        }
        else if (args.Index == 1)
        {
            ButtonSizeType = SizeType.Middle;
        }
        else
        {
            ButtonSizeType = SizeType.Small;
        }
    }
    
    public void HandleLoadingBtnClick(object? sender, RoutedEventArgs args)
    {
        if (sender is Button button)
        {
            button.IsLoading = true;
            Dispatcher.UIThread.InvokeAsync(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                button.IsLoading = false;
            });
        }
    }
}