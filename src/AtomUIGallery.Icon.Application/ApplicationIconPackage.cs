using AtomUI.IconPkg;

namespace AtomUIGallery.Icon.Application;

public partial class ApplicationIconPackage : IconPackage
{
    public static ApplicationIconPackage Current { get; }

    static ApplicationIconPackage()
    {
        Current = new ApplicationIconPackage();
    }
    
    public ApplicationIconPackage()
        : base("AtomUIGalleryIcon")
    {
        SetupIconPool();
    }

    private partial void SetupIconPool();
    
    public IconInfo GetIconInfo(ApplicationIconKind iconKind)
    {
        return GetIconInfo((int)iconKind)!;
    }

    public IconInfo GetIconInfo(ApplicationIconKind iconKind, ColorInfo colorInfo)
    {
        return GetIconInfo((int)iconKind, colorInfo)!;
    }

    public IconInfo GetIconInfo(ApplicationIconKind iconKind, TwoToneColorInfo twoToneColorInfo)
    {
        return GetIconInfo((int)iconKind, twoToneColorInfo)!;
    }

    public override IconInfo? GetIconInfo(string iconKind)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return GetIconInfo(kind);
        }

        return null;
    }

    public override IconInfo? GetIconInfo(string iconKind, ColorInfo colorInfo)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return GetIconInfo(kind, colorInfo);
        }

        return null;
    }

    public override IconInfo? GetIconInfo(string iconKind, TwoToneColorInfo twoToneColorInfo)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return GetIconInfo(kind, twoToneColorInfo);
        }

        return null;
    }
    
    public AtomUI.IconPkg.Icon BuildIcon(ApplicationIconKind iconKind)
    {
        return BuildIcon((int)iconKind)!;
    }

    public AtomUI.IconPkg.Icon BuildIcon(ApplicationIconKind iconKind, ColorInfo colorInfo)
    {
        return BuildIcon((int)iconKind, colorInfo)!;
    }

    public AtomUI.IconPkg.Icon BuildIcon(ApplicationIconKind iconKind, TwoToneColorInfo twoToneColorInfo)
    {
        return BuildIcon((int)iconKind, twoToneColorInfo)!;
    }

    public override AtomUI.IconPkg.Icon? BuildIcon(string iconKind)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return BuildIcon(kind);
        }

        return null;
    }

    public override AtomUI.IconPkg.Icon? BuildIcon(string iconKind, ColorInfo colorInfo)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return BuildIcon(kind, colorInfo);
        }

        return null;
    }

    public override AtomUI.IconPkg.Icon? BuildIcon(string iconKind, TwoToneColorInfo twoToneColorInfo)
    {
        if (Enum.TryParse(iconKind, out ApplicationIconKind kind))
        {
            return BuildIcon(kind, twoToneColorInfo);
        }

        return null;
    }
}