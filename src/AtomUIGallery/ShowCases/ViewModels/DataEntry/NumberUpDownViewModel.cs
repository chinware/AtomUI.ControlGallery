﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class NumberUpDownViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "NumberUpDownShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;

    public NumberUpDownViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}