using Avalonia;
using Avalonia.Controls;

namespace AtomUIGallery.Controls;

public class ShowCaseItem : ContentControl
{
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<ShowCaseItem, string>(nameof(Title));

    public static readonly StyledProperty<string> DescriptionProperty =
        AvaloniaProperty.Register<ShowCaseItem, string>(nameof(Description));
    
    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }
}