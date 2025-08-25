﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class TimelineViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Timeline";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public TimelineViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}