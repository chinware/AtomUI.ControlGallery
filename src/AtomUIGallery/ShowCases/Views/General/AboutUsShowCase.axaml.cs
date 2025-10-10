using AtomUI.Controls;
using AtomUI.Data;
using AtomUI.Theme;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class AboutUsShowCase : ReactiveUserControl<AboutUsViewModel>
{
    public static readonly StyledProperty<bool> IsDarkThemeModeProperty =
        IThemeManager.IsDarkThemeModeProperty.AddOwner<AboutUsShowCase>();
    
    public bool IsDarkThemeMode
    {
        get => GetValue(IsDarkThemeModeProperty);
        set => SetValue(IsDarkThemeModeProperty, value);
    }
    
    public AboutUsShowCase()
    {
        this.WhenActivated(disposables =>
        {
            var themeManager = Application.Current?.GetThemeManager();
            if (themeManager != null)
            {
                disposables.Add(BindUtils.RelayBind(themeManager.BindingSource, IThemeManager.IsDarkThemeModeProperty, this, IsDarkThemeModeProperty));
            }
        });
        InitializeComponent();
    }
}