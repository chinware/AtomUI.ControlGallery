using AtomUIGallery.ShowCases.ViewModels;
using AtomUIGallery.ShowCases.Views;
using ReactiveUI;
using Splat;

namespace AtomUIGallery.ShowCases;

internal static class ShowCaseRegister
{
    public static void Register()
    {
        Locator.CurrentMutable.Register(() => new AlertShowCase(), typeof(IViewFor<AlertShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new BadgeShowCase(), typeof(IViewFor<BadgeShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ButtonShowCase(), typeof(IViewFor<ButtonShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ButtonSpinnerShowCase(), typeof(IViewFor<ButtonSpinnerShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new CalendarShowCase(), typeof(IViewFor<CalendarShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new CheckBoxShowCase(), typeof(IViewFor<CheckBoxShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new CollapseShowCase(), typeof(IViewFor<CollapseShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ComboBoxShowCase(), typeof(IViewFor<ComboBoxShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new DatePickerShowCase(), typeof(IViewFor<DatePickerShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new DrawerShowCase(), typeof(IViewFor<DrawerShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new DropdownButtonShowCase(), typeof(IViewFor<DropdownButtonShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new EmptyShowCase(), typeof(IViewFor<EmptyShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ExpanderShowCase(), typeof(IViewFor<ExpanderShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new GroupBoxShowCase(), typeof(IViewFor<GroupBoxShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new IconShowCase(), typeof(IViewFor<IconShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new InfoFlyoutShowCase(), typeof(IViewFor<InfoFlyoutShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new LineEditShowCase(), typeof(IViewFor<LineEditShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ListBoxShowCase(), typeof(IViewFor<ListBoxShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new LoadingIndicatorShowCase(), typeof(IViewFor<LoadingIndicatorShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new MenuShowCase(), typeof(IViewFor<MenuShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new MessageShowCase(), typeof(IViewFor<MessageShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new NotificationShowCase(), typeof(IViewFor<NotificationShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new NumberUpDownShowCase(), typeof(IViewFor<NumberUpDownShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new PaletteShowCase(), typeof(IViewFor<PaletteShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new PopupConfirmShowCase(), typeof(IViewFor<PopupConfirmShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ProgressBarShowCase(), typeof(IViewFor<ProgressBarShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new RadioButtonShowCase(), typeof(IViewFor<RadioButtonShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new SegmentedShowCase(), typeof(IViewFor<SegmentedShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new SeparatorShowCase(), typeof(IViewFor<SeparatorShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new SliderShowCase(), typeof(IViewFor<SliderShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new SplitButtonShowCase(), typeof(IViewFor<SplitButtonShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new ToggleSwitchShowCase(), typeof(IViewFor<SwitchShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TabControlShowCase(), typeof(IViewFor<TabControlShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TagShowCase(), typeof(IViewFor<TagShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TimelineShowCase(), typeof(IViewFor<TimelineShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TimePickerShowCase(), typeof(IViewFor<TimePickerShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TooltipShowCase(), typeof(IViewFor<TooltipShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new TreeViewShowCase(), typeof(IViewFor<TreeViewShowCaseViewModel>));
        Locator.CurrentMutable.Register(() => new WatermarkShowCase(), typeof(IViewFor<WatermarkShowCaseViewModel>));
    }
}