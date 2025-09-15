using System.Reactive.Disposables;
using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ModalShowCase : ReactiveUserControl<ModalViewModel>
{
    public ModalShowCase()
    {
        this.WhenActivated(disposables =>
        {
            BasicOpenModalButton.Click       += HandleBasicModalButtonClick;
            BasicWindowOpenModalButton.Click += HandleBasicWindowModalButtonClick;

            ConfirmMsgBoxBtn.Click     += HandleConfirmMsgBoxBtnClick;
            InformationMsgBoxBtn.Click += HandleInformationMsgBoxBtnClick;
            SuccessMsgBoxBtn.Click     += HandleSuccessMsgBoxBtnClick;
            ErrorMsgBoxBtn.Click       += HandleErrorMsgBoxBtnClick;
            WarningMsgBoxBtn.Click     += HandleWarningMsgBoxBtnClick;

            StyleCaseHostTypeSwitch.IsCheckedChanged += HandleStyleCaseHostTypeSwitchChanged;
            
            disposables.Add(Disposable.Create(() => BasicOpenModalButton.Click       -= HandleBasicModalButtonClick));
            disposables.Add(Disposable.Create(() => BasicWindowOpenModalButton.Click -= HandleBasicWindowModalButtonClick));
            disposables.Add(Disposable.Create(() => ConfirmMsgBoxBtn.Click -= HandleConfirmMsgBoxBtnClick));
            disposables.Add(Disposable.Create(() => InformationMsgBoxBtn.Click -= HandleInformationMsgBoxBtnClick));
            disposables.Add(Disposable.Create(() => SuccessMsgBoxBtn.Click -= HandleSuccessMsgBoxBtnClick));
            disposables.Add(Disposable.Create(() => ErrorMsgBoxBtn.Click -= HandleErrorMsgBoxBtnClick));
            disposables.Add(Disposable.Create(() => WarningMsgBoxBtn.Click -= HandleWarningMsgBoxBtnClick));
            disposables.Add(Disposable.Create(() => StyleCaseHostTypeSwitch.IsCheckedChanged -= HandleStyleCaseHostTypeSwitchChanged));

            if (DataContext is ModalViewModel viewModel)
            {
                viewModel.MessageBoxStyleCaseHostType = DialogHostType.Overlay;
            }
        });
        InitializeComponent();
    }

    private void HandleBasicModalButtonClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsBasicModalOpened = true;
        }
    }
    
    private void HandleBasicWindowModalButtonClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsBasicWindowModalOpened = true;
        }
    }
    
    private void HandleConfirmMsgBoxBtnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsConfirmMsgBoxOpened = true;
        }
    }
    
    private void HandleInformationMsgBoxBtnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsInformationMsgBoxOpened = true;
        }
    }
    
    private void HandleSuccessMsgBoxBtnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsSuccessMsgBoxOpened = true;
        }
    }
    
    private void HandleErrorMsgBoxBtnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsErrorMsgBoxOpened = true;
        }
    }
    
    private void HandleWarningMsgBoxBtnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is ModalViewModel viewModel)
        {
            viewModel.IsWarningMsgBoxOpened = true;
        }
    }

    private void HandleStyleCaseHostTypeSwitchChanged(object? sender, RoutedEventArgs e)
    {
        if (sender is ToggleSwitch toggleSwitch)
        {
            if (DataContext is ModalViewModel viewModel)
            {
                viewModel.MessageBoxStyleCaseHostType = toggleSwitch.IsChecked == true ? DialogHostType.Window : DialogHostType.Overlay;
            }
        }
    }
}