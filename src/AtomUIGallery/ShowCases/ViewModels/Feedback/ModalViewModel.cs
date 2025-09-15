using AtomUI.Controls;
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

    private bool _isBasicWindowModalOpened;

    public bool IsBasicWindowModalOpened
    {
        get => _isBasicWindowModalOpened;
        set => this.RaiseAndSetIfChanged(ref _isBasicWindowModalOpened, value);
    }
    
    private DialogHostType _messageBoxStyleCaseHostType;

    public DialogHostType MessageBoxStyleCaseHostType
    {
        get => _messageBoxStyleCaseHostType;
        set => this.RaiseAndSetIfChanged(ref _messageBoxStyleCaseHostType, value);
    }
    
    private bool _isInformationMsgBoxOpened;

    public bool IsInformationMsgBoxOpened
    {
        get => _isInformationMsgBoxOpened;
        set => this.RaiseAndSetIfChanged(ref _isInformationMsgBoxOpened, value);
    }
    
    private bool _isSuccessMsgBoxOpened;

    public bool IsSuccessMsgBoxOpened
    {
        get => _isSuccessMsgBoxOpened;
        set => this.RaiseAndSetIfChanged(ref _isSuccessMsgBoxOpened, value);
    }
        
    private bool _isErrorMsgBoxOpened;

    public bool IsErrorMsgBoxOpened
    {
        get => _isErrorMsgBoxOpened;
        set => this.RaiseAndSetIfChanged(ref _isErrorMsgBoxOpened, value);
    }
    
    private bool _isWarningMsgBoxOpened;

    public bool IsWarningMsgBoxOpened
    {
        get => _isWarningMsgBoxOpened;
        set => this.RaiseAndSetIfChanged(ref _isWarningMsgBoxOpened, value);
    }

    public ModalViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}