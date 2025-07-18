﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class EmptyViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "EmptyShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public EmptyViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}