using AtomUI.Controls;
using AtomUIGallery.ShowCases.ViewModels;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.Views;

public partial class DataGridShowCase : ReactiveUserControl<DataGridViewModel>
{
    public DataGridShowCase()
    {
        this.WhenActivated(disposables =>
        {
            if (DataContext is DataGridViewModel viewModel)
            {
                // BasicCaseGrid.ItemsSource = viewModel.BasicCaseDataSource;
                // SelectionDataGrid.ItemsSource = viewModel.BasicCaseDataSource;
                FilterAndSortGrid.ItemsSource = viewModel.FilterAndSorterDataSource;
            }

            // ExtendedSelection.IsCheckedChanged += SelectionModeCheckedChanged;
            // SingleSelection.IsCheckedChanged += SelectionModeCheckedChanged;
        });
        InitializeComponent();
    }
    
    private void SelectionModeCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            // if (radioButton == ExtendedSelection && ExtendedSelection.IsChecked.HasValue && ExtendedSelection.IsChecked.Value)
            // {
            //     SelectionDataGrid.SelectionMode = DataGridSelectionMode.Extended;
            // }
            // else if (radioButton == SingleSelection && SingleSelection.IsChecked.HasValue && SingleSelection.IsChecked.Value)
            // {
            //     SelectionDataGrid.SelectionMode = DataGridSelectionMode.Single;
            // }
        }
    }
}
