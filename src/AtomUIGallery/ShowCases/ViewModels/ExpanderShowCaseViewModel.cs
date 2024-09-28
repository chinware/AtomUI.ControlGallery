﻿using AtomUI.Controls;
using Avalonia.Controls;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ExpanderShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ExpanderShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    private ExpanderIconPosition _toggleIconPosition;

    public ExpanderIconPosition ToggleIconPosition
    {
        get => _toggleIconPosition;
        set => this.RaiseAndSetIfChanged(ref _toggleIconPosition, value);
    }
    
    private ExpandDirection _expandDirection;

    public ExpandDirection ExpandDirection
    {
        get => _expandDirection;
        set => this.RaiseAndSetIfChanged(ref _expandDirection, value);
    }

    public ExpanderShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
    
    public void HandleExpandButtonPosOptionCheckedChanged(object? sender, OptionCheckedChangedEventArgs args)
    {
        if (args.Index == 0)
        {
            ToggleIconPosition = ExpanderIconPosition.Start;
        }
        else if (args.Index == 1)
        {
            ToggleIconPosition = ExpanderIconPosition.End;
        }
    }

    public void HandleExpandDirectionOptionCheckedChanged(object? sender, OptionCheckedChangedEventArgs args)
    {
        if (args.Index == 0)
        {
            ExpandDirection = ExpandDirection.Down;
        }
        else if (args.Index == 1)
        {
            ExpandDirection = ExpandDirection.Up;
        }
        else if (args.Index == 2)
        {
            ExpandDirection = ExpandDirection.Left;
        }
        else if (args.Index == 3)
        {
            ExpandDirection = ExpandDirection.Right;
        }
    }
}