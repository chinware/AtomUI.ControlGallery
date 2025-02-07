using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class GroupBoxShowCase : ReactiveUserControl<GroupBoxViewModel>
{
    public GroupBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}