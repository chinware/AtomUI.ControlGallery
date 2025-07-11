﻿using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ComboBoxShowCase : ReactiveUserControl<ComboBoxViewModel>
{
    public ComboBoxShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}