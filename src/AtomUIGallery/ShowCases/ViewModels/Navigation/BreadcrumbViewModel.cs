using System.Collections.ObjectModel;
using AtomUI.Controls;
using ReactiveUI;
using AtomUI.Controls.Utils;
using AtomUI.IconPkg.AntDesign;

namespace AtomUIGallery.ShowCases.ViewModels;

public class BreadcrumbViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "BreadcrumbShowCase";
    
    public ObservableCollection<BreadcrumbItem> BreadcrumbItemsCase1 { get; } = new()
    {
        new BreadcrumbItem() { Title = "Home" },
        new BreadcrumbItem() { Title = "Application Center" },
        new BreadcrumbItem() { Title = "Application List" },
        new BreadcrumbItem() { Title = "An Application" },
    };
    
    public ObservableCollection<BreadcrumbItem> BreadcrumbItemsCase2 { get; } = new()
    {
        new BreadcrumbItem() { Icon = new AntDesignIconPackage().BuildIcon("HomeOutlined") },
        new BreadcrumbItem() { Title = "Application List", Icon = new AntDesignIconPackage().BuildIcon("UserOutlined") },
        new BreadcrumbItem() { Title = "Application" },
    };
    
    public ObservableCollection<BreadcrumbItem> BreadcrumbItemsCase3 { get; } = new()
    {
        new BreadcrumbItem() { Icon = new AntDesignIconPackage().BuildIcon("HomeOutlined") },
        new BreadcrumbItem() { Title = "Application List", Icon = new AntDesignIconPackage().BuildIcon("UserOutlined") },
        new BreadcrumbItem() { Title = "Application", Value = "War3"},
    };
    
    public ObservableCollection<BreadcrumbItem> BreadcrumbItemsCase4 { get; } = new()
    {
        new BreadcrumbItem() { Title = "Home" },
        new BreadcrumbItem() { Title = "Application Center" },
        new BreadcrumbItem() { Title = "Application List" },
        new BreadcrumbItem() { Title = "An Application" },
    };
    
    public ObservableCollection<BreadcrumbItem> BreadcrumbItemsCase5 { get; } = new()
    {
        new BreadcrumbItem() { Title = "Location", Separator = ":"},
        new BreadcrumbItem() { Title = "Application Center" },
        new BreadcrumbItem() { Title = "Application List" },
        new BreadcrumbItem() { Title = "An Application" },
    };
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    public BreadcrumbViewModel(IScreen screen)
    {
        HostScreen = screen;
    }

}