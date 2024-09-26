using Avalonia;
using Avalonia.Controls.Primitives;

namespace AtomUIGallery.Controls;

public class IconInfoItem : TemplatedControl
{
    public static readonly StyledProperty<string> IconNameProperty = 
        AvaloniaProperty.Register<IconInfoItem, string>(nameof(IconName));
    
    public static readonly StyledProperty<string> IconKindProperty = 
        AvaloniaProperty.Register<IconInfoItem, string>(nameof(IconKind));

    public string IconName
    {
        get => GetValue(IconNameProperty);
        set => SetValue(IconNameProperty, value);
    }
    
    public string IconKind
    {
        get => GetValue(IconKindProperty);
        set => SetValue(IconKindProperty, value);
    }
}