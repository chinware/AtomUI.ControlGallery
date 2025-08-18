﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class CalendarViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Calendar";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    public CalendarViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}