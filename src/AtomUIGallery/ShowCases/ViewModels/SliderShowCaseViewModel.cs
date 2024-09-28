using AtomUI.Controls;
using Avalonia.Collections;
using Avalonia.Media;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class SliderShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "SliderShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    private AvaloniaList<SliderMark>? _sliderMarks;

    public AvaloniaList<SliderMark>? SliderMarks
    {
        get => _sliderMarks;
        set => this.RaiseAndSetIfChanged(ref _sliderMarks, value);
    }

    private bool _normalDisabled;

    public bool NormalDisabled
    {
        get => _normalDisabled;
        set => this.RaiseAndSetIfChanged(ref _normalDisabled, value);
    }
        
    public SliderShowCaseViewModel(IScreen screen)
    {
        HostScreen  = screen;
        SliderMarks = new AvaloniaList<SliderMark>();
        SliderMarks.Add(new SliderMark("0°C", 0));
        SliderMarks.Add(new SliderMark("26°C", 26));
        SliderMarks.Add(new SliderMark("37°C", 37));
        SliderMarks.Add(new SliderMark("100°C", 100)
        {
            LabelFontWeight = FontWeight.Bold,
            LabelBrush      = new SolidColorBrush(Colors.Red)
        });
    }
}