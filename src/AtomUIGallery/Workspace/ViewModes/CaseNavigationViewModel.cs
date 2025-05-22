using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.Threading;
using ReactiveUI;

namespace AtomUIGallery.Workspace.ViewModes;

public class CaseNavigationViewModel : ReactiveObject
{
    private Dictionary<string, Func<IRoutableViewModel>> _showCaseViewModelFactories;
    private Dictionary<string, IRoutableViewModel> _showCaseViewModels;
    private string? _currentShowCase;
    private DispatcherTimer _dispatcherTimer;

    public IScreen HostScreen { get; }

    public CaseNavigationViewModel(IScreen hostScreen)
    {
        _showCaseViewModelFactories = new Dictionary<string, Func<IRoutableViewModel>>();
        _showCaseViewModels         = new Dictionary<string, IRoutableViewModel>();
        HostScreen                  = hostScreen;
        RegisterShowCaseViewModels();
        _dispatcherTimer      =  new DispatcherTimer();
        _dispatcherTimer.Tick += RandomNavigateToTimerHandler;
    }

    private void RegisterShowCaseViewModels()
    {
        RegisterGeneralViewModels();
        RegisterDataDisplayViewModels();
        RegisterDataEntryViewModels();
        RegisterFeedbackViewModels();
        RegisterNavigationViewModels();
    }

    private void RegisterGeneralViewModels()
    {
        _showCaseViewModelFactories.Add(ButtonViewModel.ID, () => new ButtonViewModel(HostScreen));
        _showCaseViewModelFactories.Add(IconViewModel.ID, () => new IconViewModel(HostScreen));
        _showCaseViewModelFactories.Add(PaletteViewModel.ID, () => new PaletteViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SeparatorViewModel.ID, () => new SeparatorViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SplitButtonViewModel.ID, () => new SplitButtonViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CustomizeThemeViewModel.ID, () => new CustomizeThemeViewModel(HostScreen));
    }

    private void RegisterDataDisplayViewModels()
    {
        _showCaseViewModelFactories.Add(BadgeViewModel.ID, () => new BadgeViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CalendarViewModel.ID, () => new CalendarViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CollapseViewModel.ID, () => new CollapseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(EmptyViewModel.ID, () => new EmptyViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ExpanderViewModel.ID, () => new ExpanderViewModel(HostScreen));
        _showCaseViewModelFactories.Add(GroupBoxViewModel.ID, () => new GroupBoxViewModel(HostScreen));
        _showCaseViewModelFactories.Add(InfoFlyoutViewModel.ID, () => new InfoFlyoutViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ListBoxViewModel.ID, () => new ListBoxViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SegmentedViewModel.ID, () => new SegmentedViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TabControlViewModel.ID, () => new TabControlViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TagViewModel.ID, () => new TagViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TimelineViewModel.ID, () => new TimelineViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TooltipViewModel.ID, () => new TooltipViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TreeViewViewModel.ID, () => new TreeViewViewModel(HostScreen));
    }

    private void RegisterDataEntryViewModels()
    {
        _showCaseViewModelFactories.Add(CheckBoxViewModel.ID, () => new CheckBoxViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DatePickerViewModel.ID, () => new DatePickerViewModel(HostScreen));
        _showCaseViewModelFactories.Add(LineEditViewModel.ID, () => new LineEditViewModel(HostScreen));
        _showCaseViewModelFactories.Add(NumberUpDownViewModel.ID, () => new NumberUpDownViewModel(HostScreen));
        _showCaseViewModelFactories.Add(RadioButtonViewModel.ID, () => new RadioButtonViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SliderViewModel.ID, () => new SliderViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TimePickerViewModel.ID, () => new TimePickerViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ToggleSwitchViewModel.ID, () => new ToggleSwitchViewModel(HostScreen));
    }

    private void RegisterFeedbackViewModels()
    {
        _showCaseViewModelFactories.Add(AlertViewModel.ID, () => new AlertViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DrawerViewModel.ID, () => new DrawerViewModel(HostScreen));
        _showCaseViewModelFactories.Add(LoadingIndicatorViewModel.ID, () => new LoadingIndicatorViewModel(HostScreen));
        _showCaseViewModelFactories.Add(MessageViewModel.ID, () => new MessageViewModel(HostScreen));
        _showCaseViewModelFactories.Add(NotificationViewModel.ID, () => new NotificationViewModel(HostScreen));
        _showCaseViewModelFactories.Add(PopupConfirmViewModel.ID, () => new PopupConfirmViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ProgressBarViewModel.ID, () => new ProgressBarViewModel(HostScreen));
        _showCaseViewModelFactories.Add(WatermarkViewModel.ID, () => new WatermarkViewModel(HostScreen));
    }

    private void RegisterNavigationViewModels()
    {
        _showCaseViewModelFactories.Add(ButtonSpinnerViewModel.ID, () => new ButtonSpinnerViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ComboBoxViewModel.ID, () => new ComboBoxViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DropdownButtonViewModel.ID, () => new DropdownButtonViewModel(HostScreen));
        _showCaseViewModelFactories.Add(MenuViewModel.ID, () => new MenuViewModel(HostScreen));
        _showCaseViewModelFactories.Add(PaginationViewModel.ID, () => new PaginationViewModel(HostScreen));
    }

    public void NavigateTo(string showCaseId)
    {
        if (_currentShowCase is not null && _currentShowCase == showCaseId)
        {
            return;
        }

        _currentShowCase = showCaseId;
        IRoutableViewModel? viewModel = null;

        if (_showCaseViewModels.ContainsKey(showCaseId))
        {
            viewModel = _showCaseViewModels[showCaseId];
        }
        else
        {
            if (!_showCaseViewModelFactories.ContainsKey(showCaseId))
            {
                // TODO 应该写日志或者抛出异常？
                return;
            }

            viewModel = _showCaseViewModelFactories[showCaseId]();
            _showCaseViewModels.Add(showCaseId, viewModel);
        }

        HostScreen.Router.Navigate.Execute(viewModel);
    }
    
    private static int _currentShowCaseIdx = 0;

    private void RandomNavigateToTimerHandler(object? sender, EventArgs e)
    {
        var    caseIds      = _showCaseViewModelFactories.Keys.ToList();
        // Random random       = new Random();
        // var    nextKeyIndex = random.Next(caseIds.Count);
        var id = caseIds[_currentShowCaseIdx++ % caseIds.Count];
        NavigateTo(id);
    }

    public void TestNavigatePages(TimeSpan interval)
    {
        _dispatcherTimer.Stop();
        _dispatcherTimer.Interval = interval;
        _dispatcherTimer.Start();
    }

    public void StopTestNavigatePages()
    {
        _dispatcherTimer.Stop();
    }
}