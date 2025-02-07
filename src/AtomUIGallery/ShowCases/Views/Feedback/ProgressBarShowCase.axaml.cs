using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ProgressBarShowCase : ReactiveUserControl<ProgressBarShowCaseViewModel>
{
    public ProgressBarShowCase()
    {
        this.WhenActivated(disposables =>
        {
            
        });
        InitializeComponent();
    }
}