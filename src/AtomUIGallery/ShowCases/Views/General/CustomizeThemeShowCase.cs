using System.Reactive.Disposables;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class CustomizeThemeShowCase : ReactiveUserControl<CustomizeThemeViewModel>
{
    public CustomizeThemeShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is CustomizeThemeViewModel customizeThemeModel)
            {
            }
        });
        InitializeComponent();
    }
}