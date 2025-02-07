﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ToggleSwitchViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ToggleSwitchShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public ToggleSwitchViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}