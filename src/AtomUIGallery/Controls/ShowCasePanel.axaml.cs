using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Metadata;
using AvaloniaControlList = Avalonia.Controls.Controls;

namespace AtomUIGallery.Controls;

public class ShowCasePanel : TemplatedControl
{
    internal const string LeftPanelPart = "PART_LeftPanel";
    internal const string RightPanelPart = "PART_RightPanel";

    private bool _initialized;
    private StackPanel? _leftPanel;
    private StackPanel? _rightPanel;

    [Content]
    public AvaloniaControlList Children { get; } = new();

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        _leftPanel  = e.NameScope.Get<StackPanel>(LeftPanelPart);
        _rightPanel = e.NameScope.Get<StackPanel>(RightPanelPart);
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        if (!_initialized)
        {
            for (var i = 0; i < Children.Count; ++i)
            {
                var control = Children[i];
                if (i % 2 == 0)
                {
                    _leftPanel?.Children.Add(control);
                }
                else
                {
                    _rightPanel?.Children.Add(control);
                }
            }

            _initialized = true;
        }
    }

    internal virtual void NotifyAboutToActive()
    {
    }

    internal virtual void NotifyActivated()
    {
    }

    internal virtual void NotifyAboutToDeactivated()
    {
    }

    internal virtual void NotifyDeactivated()
    {
    }
}