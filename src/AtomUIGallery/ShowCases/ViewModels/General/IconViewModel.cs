﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class IconViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "IconShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public IconViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}