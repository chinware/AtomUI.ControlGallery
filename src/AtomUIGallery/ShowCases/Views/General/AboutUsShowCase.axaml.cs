using AtomUI;
using AtomUI.Data;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class AboutUsShowCase : ReactiveUserControl<AboutUsViewModel>
{
    public static readonly StyledProperty<bool> IsDarkThemeModeProperty =
        AtomApplication.IsDarkThemeModeProperty.AddOwner<AboutUsShowCase>();
    
    public bool IsDarkThemeMode
    {
        get => GetValue(IsDarkThemeModeProperty);
        set => SetValue(IsDarkThemeModeProperty, value);
    }
    
    public AboutUsShowCase()
    {
        this.WhenActivated(disposables =>
        {
            var application = AtomApplication.GetInstance();
            if (application != null)
            {
                disposables.Add(BindUtils.RelayBind(application, AtomApplication.IsDarkThemeModeProperty, this, IsDarkThemeModeProperty));
            }
        });
        InitializeComponent();
    }
}