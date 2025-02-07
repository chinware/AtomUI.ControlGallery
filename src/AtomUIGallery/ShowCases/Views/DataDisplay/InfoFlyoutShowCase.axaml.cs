using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class InfoFlyoutShowCase : ReactiveUserControl<InfoFlyoutViewModel>
{
    public InfoFlyoutShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is InfoFlyoutViewModel viewModel)
            {
                ArrowSegmented.SelectionChanged += viewModel.HandleSelectionChanged;
            }
        });
        InitializeComponent();
    }
}