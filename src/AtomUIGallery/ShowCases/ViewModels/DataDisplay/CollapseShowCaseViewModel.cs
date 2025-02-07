﻿using AtomUI.Controls;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CollapseShowCaseViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "CollapseShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    private CollapseExpandIconPosition _collapseExpandIconPosition;

    public CollapseExpandIconPosition CollapseExpandIconPosition
    {
        get => _collapseExpandIconPosition;
        set => this.RaiseAndSetIfChanged(ref _collapseExpandIconPosition, value);
    }

    public CollapseShowCaseViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
    
    public void HandleExpandButtonPosOptionCheckedChanged(object? sender, OptionCheckedChangedEventArgs args)
    {
        if (args.Index == 0)
        {
            CollapseExpandIconPosition = CollapseExpandIconPosition.Start;
        }
        else if (args.Index == 1)
        {
            CollapseExpandIconPosition = CollapseExpandIconPosition.End;
        }
    }
}