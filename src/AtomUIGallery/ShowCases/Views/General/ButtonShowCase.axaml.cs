﻿using AtomUI;
using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using Avalonia.Threading;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ButtonShowCase : ReactiveUserControl<ButtonViewModel>
{
    private ButtonViewModel? _viewModel;
    public ButtonShowCase()
    {
        this.WhenActivated(disposables =>
        {
            _viewModel = DataContext as ButtonViewModel;
        });
        InitializeComponent();
    }
    
    public void HandleButtonSizeTypeOptionCheckedChanged(object? sender, OptionCheckedChangedEventArgs args)
    {
        if (_viewModel != null)
        {
            if (args.Index == 0)
            {
                _viewModel.ButtonSizeType = SizeType.Large;
            }
            else if (args.Index == 1)
            {
                _viewModel.ButtonSizeType = SizeType.Middle;
            }
            else
            {
                _viewModel.ButtonSizeType = SizeType.Small;
            }
        }
        
    }

    public void HandleLoadingBtnClick(object? sender, RoutedEventArgs args)
    {
        if (sender is Button button)
        {
            button.IsLoading = true;
            Dispatcher.UIThread.InvokeAsync(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                button.IsLoading = false;
            });
        }
    }
}