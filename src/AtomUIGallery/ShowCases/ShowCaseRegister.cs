using AtomUIGallery.ShowCases.ViewModels;
using AtomUIGallery.ShowCases.Views;
using ReactiveUI;
using Splat;

namespace AtomUIGallery.ShowCases;

internal static class ShowCaseRegister
{
    public static void Register()
    {
        RegisterGeneralCases();
        RegisterDataDisplayCases();
        RegisterDataEntryCases();
        RegisterFeedbackCases();
        RegisterNavigationCases();
    }

    private static void RegisterGeneralCases()
    {
        Locator.CurrentMutable.Register(() => new ButtonShowCase(), typeof(IViewFor<ButtonViewModel>));
        Locator.CurrentMutable.Register(() => new CustomizeThemeShowCase(), typeof(IViewFor<CustomizeThemeViewModel>));
        Locator.CurrentMutable.Register(() => new IconShowCase(), typeof(IViewFor<IconViewModel>));
        Locator.CurrentMutable.Register(() => new PaletteShowCase(), typeof(IViewFor<PaletteViewModel>));
        Locator.CurrentMutable.Register(() => new SeparatorShowCase(), typeof(IViewFor<SeparatorViewModel>));
        Locator.CurrentMutable.Register(() => new SplitButtonShowCase(), typeof(IViewFor<SplitButtonViewModel>));
    }
    
    private static void RegisterDataDisplayCases()
    {
        Locator.CurrentMutable.Register(() => new BadgeShowCase(), typeof(IViewFor<BadgeViewModel>));
        Locator.CurrentMutable.Register(() => new CalendarShowCase(), typeof(IViewFor<CalendarViewModel>));
        Locator.CurrentMutable.Register(() => new CollapseShowCase(), typeof(IViewFor<CollapseViewModel>));
        Locator.CurrentMutable.Register(() => new DataGridShowCase(), typeof(IViewFor<DataGridViewModel>));
        Locator.CurrentMutable.Register(() => new EmptyShowCase(), typeof(IViewFor<EmptyViewModel>));
        Locator.CurrentMutable.Register(() => new ExpanderShowCase(), typeof(IViewFor<ExpanderViewModel>));
        Locator.CurrentMutable.Register(() => new GroupBoxShowCase(), typeof(IViewFor<GroupBoxViewModel>));
        Locator.CurrentMutable.Register(() => new InfoFlyoutShowCase(), typeof(IViewFor<InfoFlyoutViewModel>));
        Locator.CurrentMutable.Register(() => new ListBoxShowCase(), typeof(IViewFor<ListBoxViewModel>));
        Locator.CurrentMutable.Register(() => new SegmentedShowCase(), typeof(IViewFor<SegmentedViewModel>));
        Locator.CurrentMutable.Register(() => new TabControlShowCase(), typeof(IViewFor<TabControlViewModel>));
        Locator.CurrentMutable.Register(() => new TagShowCase(), typeof(IViewFor<TagViewModel>));
        Locator.CurrentMutable.Register(() => new TimelineShowCase(), typeof(IViewFor<TimelineViewModel>));
        Locator.CurrentMutable.Register(() => new TooltipShowCase(), typeof(IViewFor<TooltipViewModel>));
        Locator.CurrentMutable.Register(() => new TreeViewShowCase(), typeof(IViewFor<TreeViewViewModel>));
    }
    
    private static void RegisterDataEntryCases()
    {
        Locator.CurrentMutable.Register(() => new CheckBoxShowCase(), typeof(IViewFor<CheckBoxViewModel>));
        Locator.CurrentMutable.Register(() => new DatePickerShowCase(), typeof(IViewFor<DatePickerViewModel>));
        Locator.CurrentMutable.Register(() => new LineEditShowCase(), typeof(IViewFor<LineEditViewModel>));
        Locator.CurrentMutable.Register(() => new NumberUpDownShowCase(), typeof(IViewFor<NumberUpDownViewModel>));
        Locator.CurrentMutable.Register(() => new RadioButtonShowCase(), typeof(IViewFor<RadioButtonViewModel>));
        Locator.CurrentMutable.Register(() => new SliderShowCase(), typeof(IViewFor<SliderViewModel>));
        Locator.CurrentMutable.Register(() => new TimePickerShowCase(), typeof(IViewFor<TimePickerViewModel>));
        Locator.CurrentMutable.Register(() => new ToggleSwitchShowCase(), typeof(IViewFor<ToggleSwitchViewModel>));
    }
    
    private static void RegisterFeedbackCases()
    {
        Locator.CurrentMutable.Register(() => new AlertShowCase(), typeof(IViewFor<AlertViewModel>));
        Locator.CurrentMutable.Register(() => new DrawerShowCase(), typeof(IViewFor<DrawerViewModel>));
        Locator.CurrentMutable.Register(() => new LoadingIndicatorShowCase(), typeof(IViewFor<LoadingIndicatorViewModel>));
        Locator.CurrentMutable.Register(() => new MessageShowCase(), typeof(IViewFor<MessageViewModel>));
        Locator.CurrentMutable.Register(() => new NotificationShowCase(), typeof(IViewFor<NotificationViewModel>));
        Locator.CurrentMutable.Register(() => new PopupConfirmShowCase(), typeof(IViewFor<PopupConfirmViewModel>));
        Locator.CurrentMutable.Register(() => new ProgressBarShowCase(), typeof(IViewFor<ProgressBarViewModel>));
        Locator.CurrentMutable.Register(() => new WatermarkShowCase(), typeof(IViewFor<WatermarkViewModel>));
    }
    
    private static void RegisterNavigationCases()
    {
        Locator.CurrentMutable.Register(() => new ButtonSpinnerShowCase(), typeof(IViewFor<ButtonSpinnerViewModel>));
        Locator.CurrentMutable.Register(() => new ComboBoxShowCase(), typeof(IViewFor<ComboBoxViewModel>));
        Locator.CurrentMutable.Register(() => new DropdownButtonShowCase(), typeof(IViewFor<DropdownButtonViewModel>));
        Locator.CurrentMutable.Register(() => new MenuShowCase(), typeof(IViewFor<MenuViewModel>));
        Locator.CurrentMutable.Register(() => new PaginationShowCase(), typeof(IViewFor<PaginationViewModel>));
    }
}