using AtomUI.IconPkg;
using AtomUI.IconPkg.AntDesign;
using AtomUIGallery.Models;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls.Primitives;

namespace AtomUIGallery.Controls;

public class IconGallery : TemplatedControl
{
    public static readonly StyledProperty<IconThemeType?> IconThemeTypeProperty =
        AvaloniaProperty.Register<IconInfoItem, IconThemeType?>(
            nameof(IconThemeType));

    public IconThemeType? IconThemeType
    {
        get => GetValue(IconThemeTypeProperty);
        set => SetValue(IconThemeTypeProperty, value);
    }

    #region 内部属性定义

    internal static readonly StyledProperty<AvaloniaList<PackageIconItem>?> IconInfosProperty =
        AvaloniaProperty.Register<IconInfoItem, AvaloniaList<PackageIconItem>?>(
            nameof(IconInfos));

    internal AvaloniaList<PackageIconItem>? IconInfos
    {
        get => GetValue(IconInfosProperty);
        set => SetValue(IconInfosProperty, value);
    }

    #endregion

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        ReLoadIcons();
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == IconThemeTypeProperty)
        {
            if (VisualRoot is not null)
            {
                ReLoadIcons();
            }
        }
    }

    private void ReLoadIcons()
    {
        var list = new AvaloniaList<PackageIconItem>();
        var iconInfos = AntDesignIconPackage.Current.GetIconInfos(IconThemeType);
        foreach (var iconInfo in iconInfos)
        {
            list.Add(new PackageIconItem(iconInfo.Name, iconInfo));
        }
        IconInfos = list;
    }
}