using AtomUI.Controls;
using AtomUI.Controls.Primitives;
using AtomUI.IconPkg.AntDesign;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class MenuShowCase : ReactiveUserControl<MenuViewModel>
{
    public MenuShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is MenuViewModel viewModel)
            {
                ChangeModeSwitch.IsCheckedChanged  += viewModel.HandleChangeModeCheckChanged;
                ChangeStyleSwitch.IsCheckedChanged += viewModel.HandleChangeStyleCheckChanged;
                var defaultOpenPaths = new List<TreeNodePath>();
                defaultOpenPaths.Add(new TreeNodePath("/3/SubGroup2"));
                viewModel.DefaultOpenPaths    = defaultOpenPaths;
                viewModel.DefaultSelectedPath = new TreeNodePath("/3/SubGroup1/Option1");
                InitNavMenuTreeNodes(viewModel);
            }
        });
        InitializeComponent();
    }

    private void InitNavMenuTreeNodes(MenuViewModel viewModel)
    {
        var nodes = new List<ITreeNode>();
        nodes.Add(new NavMenuTreeNode()
        {
            Header  = "Navigation One",
            Icon    = AntDesignIconPackage.MailOutlined(),
            ItemKey = "1"
        });
        nodes.Add(new NavMenuTreeNode()
        {
            Header  = "Navigation Two",
            Icon    = AntDesignIconPackage.AppstoreOutlined(),
            ItemKey = "2"
        });
        nodes.Add(new NavMenuTreeNode()
        {
            Header  = "Navigation Three - Submenu",
            Icon    = AntDesignIconPackage.SettingOutlined(),
            ItemKey = "3",
            Children = [new NavMenuTreeNode()
            {
                Header  = "Item 1",
                ItemKey = "SubGroup1",
                Children = [new NavMenuTreeNode()
                {
                    Header  = "Option 1",
                    ItemKey = "Option1",
                }, new NavMenuTreeNode()
                {
                    Header  = "Option 2",
                    ItemKey = "Option2",
                }]
            },new NavMenuTreeNode()
            {
                Header  = "Item 2",
                ItemKey = "SubGroup2",
                Children = [new NavMenuTreeNode()
                    {
                        Header  = "Option 3",
                        ItemKey = "Option3",
                    }, new NavMenuTreeNode()
                    {
                        Header  = "Option 4",
                        ItemKey = "Option4",
                    }
                ]
            }]
        });
        nodes.Add(new NavMenuTreeNode()
        {
            Header  = "Navigation Four",
            ItemKey = "4"
        });
        viewModel.NavMenuItems = nodes;
    }
}