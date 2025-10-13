using AtomUI.Controls;
using AtomUI.Controls.Primitives;
using AtomUI.IconPkg.AntDesign;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Input;
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
                InitMenuTreeNodes(viewModel);
                InitContextMenuItems(viewModel);
            }
        });
        InitializeComponent();
    }

    private void InitContextMenuItems(MenuViewModel viewModel)
    {
        var nodes = new List<IMenuItemData>();
        nodes.Add(new MenuItemData()
        {
            Header       = "Cut",
            Icon         = AntDesignIconPackage.ScissorOutlined(),
            InputGesture = KeyGesture.Parse("Ctrl+X"),
        });
        nodes.Add(new MenuItemData()
        {
            Header       = "Copy",
            Icon         = AntDesignIconPackage.CopyOutlined(),
            InputGesture = KeyGesture.Parse("Ctrl+C"),
        });
        nodes.Add(new MenuItemData()
        {
            Header       = "Delete",
            Icon         = AntDesignIconPackage.CopyOutlined(),
            InputGesture = KeyGesture.Parse("Ctrl+D"),
        });
        nodes.Add(new MenuItemData() {
                Header    = "Paste",
                Children = [
                    new MenuItemData()
                    {
                        Header       = "Paste",
                        Icon         = AntDesignIconPackage.FileDoneOutlined(),
                        InputGesture = KeyGesture.Parse("Ctrl+P")
                    },
                    new MenuItemData()
                    {
                        Header       = "Paste from History",
                        InputGesture = KeyGesture.Parse("Ctrl+Shift+V")
                    }
                ]
            }
        );
        viewModel.MenuItems = nodes;
    }

    private void InitMenuTreeNodes(MenuViewModel viewModel)
    {
        var nodes = new List<IMenuItemData>();
        nodes.Add(new MenuItemData()
        {
            Header  = "File",
            Children = [new MenuItemData()
            {
                Header       = "New Text File",
                InputGesture = KeyGesture.Parse("Ctrl+N")
            },
            new MenuItemData()
            {
                Header       = "New File",
                InputGesture = KeyGesture.Parse("Ctrl+Alt+N")
            },
            new MenuItemData()
            {
                Header       = "New Window",
                InputGesture = KeyGesture.Parse("Ctrl+Shift+N")
            }]
        });
        nodes.Add(new MenuItemData() {
                Header    = "Edit",
                Children = [
                    new MenuItemData()
                    {
                        Header       = "Undo",
                        InputGesture = KeyGesture.Parse("Ctrl+Shift+Z")
                    },
                    new MenuSeparatorData(),
                    new MenuItemData()
                    {
                        Header       = "Cut",
                        InputGesture = KeyGesture.Parse("Ctrl+X")
                    }
                ]
            }
        );
        nodes.Add(new MenuItemData() {
                Header = "Disabled Item",
                IsEnabled = false
            }
        );
        viewModel.MenuItems = nodes;
    }

    private void InitNavMenuTreeNodes(MenuViewModel viewModel)
    {
        var nodes = new List<INavMenuItemData>();
        nodes.Add(new NavMenuItemData()
        {
            Header  = "Navigation One",
            Icon    = AntDesignIconPackage.MailOutlined(),
            ItemKey = "1"
        });
        nodes.Add(new NavMenuItemData()
        {
            Header  = "Navigation Two",
            Icon    = AntDesignIconPackage.AppstoreOutlined(),
            ItemKey = "2"
        });
        nodes.Add(new NavMenuItemData()
        {
            Header  = "Navigation Three - Submenu",
            Icon    = AntDesignIconPackage.SettingOutlined(),
            ItemKey = "3",
            Children = [new NavMenuItemData()
            {
                Header  = "Item 1",
                ItemKey = "SubGroup1",
                Children = [new NavMenuItemData()
                {
                    Header  = "Option 1",
                    ItemKey = "Option1",
                }, new NavMenuItemData()
                {
                    Header  = "Option 2",
                    ItemKey = "Option2",
                }]
            },new NavMenuItemData()
            {
                Header  = "Item 2",
                ItemKey = "SubGroup2",
                Children = [new NavMenuItemData()
                    {
                        Header  = "Option 3",
                        ItemKey = "Option3",
                    }, new NavMenuItemData()
                    {
                        Header  = "Option 4",
                        ItemKey = "Option4",
                    }
                ]
            }]
        });
        nodes.Add(new NavMenuItemData()
        {
            Header  = "Navigation Four",
            ItemKey = "4"
        });
        viewModel.NavMenuItems = nodes;
    }
}