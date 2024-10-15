using AtomUI.IconPkg;

namespace AtomUIGallery.Models;

public record PackageIconItem
{
    public string IconName { get; set; }
    public IconInfo IconInfo { get; set; }

    public PackageIconItem(string iconName, IconInfo iconInfo)
    {
        IconName = iconName;
        IconInfo = iconInfo;
    }
}