﻿using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DropdownButtonShowCase : ReactiveUserControl<DropdownButtonShowCaseViewModel>
{
    public DropdownButtonShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}