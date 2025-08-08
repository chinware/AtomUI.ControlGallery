using AtomUI.Data;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Application = AtomUI.Application;

namespace AtomUIGallery.ShowCases.Views;

public partial class AboutUsShowCase : ReactiveUserControl<AboutUsViewModel>
{
    public static readonly StyledProperty<bool> IsDarkThemeModeProperty =
        Application.IsDarkThemeModeProperty.AddOwner<AboutUsShowCase>();
    
    public bool IsDarkThemeMode
    {
        get => GetValue(IsDarkThemeModeProperty);
        set => SetValue(IsDarkThemeModeProperty, value);
    }
    
    public AboutUsShowCase()
    {
        this.WhenActivated(disposables =>
        {
            var application = Application.GetInstance();
            if (application != null)
            {
                disposables.Add(BindUtils.RelayBind(application, Application.IsDarkThemeModeProperty, this, IsDarkThemeModeProperty));
            }
        });
        InitializeComponent();
    }
}