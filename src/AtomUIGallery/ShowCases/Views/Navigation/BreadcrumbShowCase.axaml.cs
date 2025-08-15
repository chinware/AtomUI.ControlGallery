using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class BreadcrumbShowCase : ReactiveUserControl<BreadcrumbViewModel>
{
    public BreadcrumbShowCase()
    {
        InitializeComponent();
    }
}