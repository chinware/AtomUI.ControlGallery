using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Controls;
using Avalonia.LogicalTree;
using Avalonia.ReactiveUI;
using Avalonia.VisualTree;
using ReactiveUI;
using ButtonSpinner = AtomUI.Controls.ButtonSpinner;

namespace AtomUIGallery.ShowCases.Views;

public partial class ButtonSpinnerShowCase : ReactiveUserControl<ButtonSpinnerViewModel>
{
    public ButtonSpinnerShowCase()
    {
        this.WhenActivated(disposables =>
        {
            BindSpinHandleRecursively(this);
        });
        InitializeComponent();
    }

    private void BindSpinHandleRecursively(Control control)
    {
        if (control is ButtonSpinner spinner)
        {
            if (DataContext is ButtonSpinnerViewModel viewModel)
            {
                spinner.Spin += viewModel.HandleSpin;
            }
        }
        else
        {
            foreach (var item in control.GetVisualChildren())
            {
                if (item is Control childControl)
                {
                    BindSpinHandleRecursively(childControl);
                }
            }
        }
    }
}