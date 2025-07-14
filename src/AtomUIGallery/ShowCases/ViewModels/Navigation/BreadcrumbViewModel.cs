using System.Collections.ObjectModel;
using System.Windows.Input;
using AtomUI.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using AtomUI.Controls;

namespace AtomUIGallery.ShowCases.ViewModels;

/*
 * @desc: 面包屑中items数据结构
 */
public class _BreadcrumbItem
{
    public string? Title   { get; set; }
    public string? Separator   { get; set; }
    public ICommand? Click { get; set; }   // 如需跳转
}

public class BreadcrumbViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BreadcrumbShowCase";

    public ObservableCollection<BreadcrumbItem> BreadcrumbItems { get; } = new()
    {
        new BreadcrumbItem() { Title = "Home", Separator               ="-" },
        new BreadcrumbItem() { Title = "IOS", Separator ="-" },
        new BreadcrumbItem() { Title = "APP", Separator   ="-" },
    };
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    public BreadcrumbViewModel(IScreen screen)
    {
        HostScreen = screen;
    }

}