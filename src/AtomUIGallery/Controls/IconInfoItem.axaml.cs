using AtomUI.IconPkg;
using Avalonia;
using Avalonia.Controls.Primitives;

namespace AtomUIGallery.Controls;

public class IconInfoItem : TemplatedControl
{
    public static readonly StyledProperty<string> IconNameProperty = 
        AvaloniaProperty.Register<IconInfoItem, string>(nameof(IconName));
    
    public static readonly StyledProperty<IconInfo> IconInfoProperty = 
        AvaloniaProperty.Register<IconInfoItem, IconInfo>(nameof(IconInfo));

    public string IconName
    {
        get => GetValue(IconNameProperty);
        set => SetValue(IconNameProperty, value);
    }
    
    public IconInfo IconInfo
    {
        get => GetValue(IconInfoProperty);
        set => SetValue(IconInfoProperty, value);
    }
}