using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Controls;
using Avalonia.Controls.Converters;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ColorPicker = AtomUI.Controls.ColorPicker;

namespace AtomUIGallery.ShowCases.Views;

public partial class ColorPickerShowCase: ReactiveUserControl<ColorPickerViewModel>
{
    public ColorPickerShowCase()
    {
        this.WhenActivated(disposables =>
        {
            ColorPicker.SetColorTextFormatter(CustomRenderText, (color, format) =>
            {
                var colorText = ColorToHexConverter.ToHexString(color, AlphaComponentPosition.Leading, false, true);
                return $"Custom Text ({colorText})";
            });
        });
        InitializeComponent();
    }
}