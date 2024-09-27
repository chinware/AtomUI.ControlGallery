﻿using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ListBoxShowCase : ReactiveUserControl<ListBoxShowCaseViewModel>
{
    public ListBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}