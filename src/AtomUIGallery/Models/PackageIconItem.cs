namespace AtomUIGallery.Models;

public record PackageIconItem
{
    public string IconName { get; set; }
    public string IconKind { get; set; }

    public PackageIconItem(string iconName, string iconKind)
    {
        IconName = iconName;
        IconKind = iconKind;
    }
}