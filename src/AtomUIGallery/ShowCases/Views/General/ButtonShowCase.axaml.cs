using System.Reactive.Disposables;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class ButtonShowCase : ReactiveUserControl<ButtonViewModel>
{
    public ButtonShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is ButtonViewModel buttonShowCaseViewModel)
            {
                ButtonSizeTypeOptionGroup.OptionCheckedChanged += buttonShowCaseViewModel.HandleButtonSizeTypeOptionCheckedChanged;
                LoadingBtn1.Click += buttonShowCaseViewModel.HandleLoadingBtnClick;
                LoadingBtn2.Click += buttonShowCaseViewModel.HandleLoadingBtnClick;
                LoadingBtn3.Click += buttonShowCaseViewModel.HandleLoadingBtnClick;
                
                Disposable.Create(() =>
                {
                    ButtonSizeTypeOptionGroup.OptionCheckedChanged -= buttonShowCaseViewModel.HandleButtonSizeTypeOptionCheckedChanged;
                    LoadingBtn1.Click -= buttonShowCaseViewModel.HandleLoadingBtnClick;
                    LoadingBtn2.Click -= buttonShowCaseViewModel.HandleLoadingBtnClick;
                    LoadingBtn3.Click -= buttonShowCaseViewModel.HandleLoadingBtnClick;
                }).DisposeWith(disposables);
            }
        });
        InitializeComponent();
    }
}