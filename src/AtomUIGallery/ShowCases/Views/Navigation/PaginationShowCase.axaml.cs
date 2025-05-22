using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class PaginationShowCase : ReactiveUserControl<PaginationViewModel>
{
    public PaginationShowCase()
    {
        InitializeComponent();
    }
}