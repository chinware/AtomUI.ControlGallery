using AtomUIGallery.ShowCases.ViewModels;
using ReactiveUI;

namespace AtomUIGallery.Workspace.ViewModes;

public class CaseNavigationViewModel : ReactiveObject
{
    private Dictionary<string, Func<IRoutableViewModel>> _showCaseViewModelFactories;
    private Dictionary<string, IRoutableViewModel> _showCaseViewModels;
    private string? _currentShowCase;
    
    public IScreen HostScreen { get; }

    public CaseNavigationViewModel(IScreen hostScreen)
    {
        _showCaseViewModelFactories = new Dictionary<string, Func<IRoutableViewModel>>();
        _showCaseViewModels         = new Dictionary<string, IRoutableViewModel>();
        HostScreen                  = hostScreen;
        RegisterShowCaseViewModels();
    }

    private void RegisterShowCaseViewModels()
    {
        _showCaseViewModelFactories.Add(AlertShowCaseViewModel.ID, () => new AlertShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(BadgeShowCaseViewModel.ID, () => new BadgeShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ButtonShowCaseViewModel.ID, () => new ButtonShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ButtonSpinnerShowCaseViewModel.ID, () => new ButtonSpinnerShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CalendarShowCaseViewModel.ID, () => new CalendarShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CheckBoxShowCaseViewModel.ID, () => new CheckBoxShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(CollapseShowCaseViewModel.ID, () => new CollapseShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ComboBoxShowCaseViewModel.ID, () => new ComboBoxShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DatePickerShowCaseViewModel.ID, () => new DatePickerShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DrawerShowCaseViewModel.ID, () => new DrawerShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(DropdownButtonShowCaseViewModel.ID, () => new DropdownButtonShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(EmptyShowCaseViewModel.ID, () => new EmptyShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ExpanderShowCaseViewModel.ID, () => new ExpanderShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(GroupBoxShowCaseViewModel.ID, () => new GroupBoxShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(IconShowCaseViewModel.ID, () => new IconShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(InfoFlyoutShowCaseViewModel.ID, () => new InfoFlyoutShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(LineEditShowCaseViewModel.ID, () => new LineEditShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ListBoxShowCaseViewModel.ID, () => new ListBoxShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(LoadingIndicatorShowCaseViewModel.ID, () => new LoadingIndicatorShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(MenuShowCaseViewModel.ID, () => new MenuShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(MessageShowCaseViewModel.ID, () => new MessageShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(NotificationShowCaseViewModel.ID, () => new NotificationShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(NumberUpDownShowCaseViewModel.ID, () => new NumberUpDownShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(PaletteShowCaseViewModel.ID, () => new PaletteShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(PopupConfirmShowCaseViewModel.ID, () => new PopupConfirmShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(ProgressBarShowCaseViewModel.ID, () => new ProgressBarShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(RadioButtonShowCaseViewModel.ID, () => new RadioButtonShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SegmentedShowCaseViewModel.ID, () => new SegmentedShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SeparatorShowCaseViewModel.ID, () => new SeparatorShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SliderShowCaseViewModel.ID, () => new SliderShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SplitButtonShowCaseViewModel.ID, () => new SplitButtonShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(SwitchShowCaseViewModel.ID, () => new SwitchShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TabControlShowCaseViewModel.ID, () => new TabControlShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TagShowCaseViewModel.ID, () => new TagShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TimelineShowCaseViewModel.ID, () => new TimelineShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TimePickerShowCaseViewModel.ID, () => new TimePickerShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TooltipShowCaseViewModel.ID, () => new TooltipShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(TreeViewShowCaseViewModel.ID, () => new TreeViewShowCaseViewModel(HostScreen));
        _showCaseViewModelFactories.Add(WatermarkShowCaseViewModel.ID, () => new WatermarkShowCaseViewModel(HostScreen));
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
}