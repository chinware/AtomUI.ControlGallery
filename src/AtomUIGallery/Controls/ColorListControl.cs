using AtomUIGallery.Models;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls.Primitives;

namespace AtomUIGallery.Controls;

public class ColorListControl : TemplatedControl
{
    public static readonly StyledProperty<AvaloniaList<PaletteColorInfo>?> ColorInfosProperty =
        AvaloniaProperty.Register<ColorListControl, AvaloniaList<PaletteColorInfo>?>(nameof(ColorInfos));

    public AvaloniaList<PaletteColorInfo>? ColorInfos
    {
        get => GetValue(ColorInfosProperty);
        set => SetValue(ColorInfosProperty, value);
    }
}