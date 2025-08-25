﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class AlertViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Alert";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public AlertViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}