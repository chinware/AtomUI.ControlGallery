using System.ComponentModel;
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
                // BasicCaseGrid.ItemsSource                 = viewModel.BasicCaseDataSource;
                // SelectionDataGrid.ItemsSource             = viewModel.BasicCaseDataSource;
                // FilterAndSortGrid.ItemsSource             = viewModel.FilterAndSorterDataSource;
                // FilterInTreeGrid.ItemsSource              = viewModel.FilterAndSorterDataSource;
                // MultiSorterDataGrid.ItemsSource           = viewModel.MultiSorterDataSource;
                // ResetFilterAndSortGrid.ItemsSource        = viewModel.BasicCaseDataSource;
                // LargeSizeDataGrid.ItemsSource             = viewModel.BasicCaseDataSource;
                // MiddleSizeDataGrid.ItemsSource            = viewModel.BasicCaseDataSource;
                // SmallSizeDataGrid.ItemsSource             = viewModel.BasicCaseDataSource;
                // CustomHeaderAndFooterDataGrid.ItemsSource = viewModel.BasicCaseDataSource;
                // ExpandableDataGrid.ItemsSource            = viewModel.ExpandableRowDataSource;
                // OrderSpecificColumnDataGrid.ItemsSource   = viewModel.ExpandableRowDataSource;
                RowAndColumnHeaderDataGrid.ItemsSource = viewModel.ExpandableRowDataSource;
            }
            
            // ExtendedSelection.IsCheckedChanged += SelectionModeCheckedChanged;
            // SingleSelection.IsCheckedChanged   += SelectionModeCheckedChanged;
            //
            // SortAgeBtn.Click                += HandleSortAgeBtnClick;
            // ClearFiltersBtn.Click           += HandleClearFiltersBtnClick;
            // ClearFiltersAndSortersBtn.Click += HandleClearFiltersAndSortersBtnClick;
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

    private void HandleSortAgeBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
     //  ResetFilterAndSortGrid.Sort(1, ListSortDirection.Descending);
    }
    
    private void HandleClearFiltersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
       // ResetFilterAndSortGrid.ClearFilters();
    }
    
    private void HandleClearFiltersAndSortersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
        // ResetFilterAndSortGrid.ClearFilters();
        // ResetFilterAndSortGrid.ClearSort();
    }
}