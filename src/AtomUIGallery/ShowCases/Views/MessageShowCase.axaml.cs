﻿using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class MessageShowCase : ReactiveUserControl<MessageShowCaseViewModel>
{
    public MessageShowCase()
    {
        this.WhenActivated(disposables => { });
        InitializeComponent();
    }
}