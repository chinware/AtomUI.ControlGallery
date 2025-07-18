﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class DropdownButtonViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DropdownButtonShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public DropdownButtonViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}