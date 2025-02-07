using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class TooltipShowCase : ReactiveUserControl<TooltipViewModel>
{
    public TooltipShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is TooltipViewModel viewModel)
            {
                ArrowSegmented.SelectionChanged += viewModel.HandleSelectionChanged;
            }
        });
        InitializeComponent();
    }
}