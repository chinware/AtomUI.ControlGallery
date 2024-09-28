using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class InfoFlyoutShowCase : ReactiveUserControl<InfoFlyoutShowCaseViewModel>
{
    public InfoFlyoutShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is InfoFlyoutShowCaseViewModel viewModel)
            {
                ArrowSegmented.SelectionChanged += viewModel.HandleSelectionChanged;
            }
        });
        InitializeComponent();
    }
}