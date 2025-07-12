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
                // RowAndColumnHeaderDataGrid.ItemsSource    = viewModel.ExpandableRowDataSource;
                // GroupHeaderDataGrid.ItemsSource           = viewModel.GroupHeaderDataSource;
                // HideColumnDataGrid.ItemsSource            = viewModel.BasicCaseDataSource;
                // FixedHeaderDataGrid.ItemsSource = viewModel.FixedHeaderDataSource;
                FixedColumnsDataGrid.ItemsSource = viewModel.FixedColumnsDataSource;
            }

            // ExtendedSelection.IsCheckedChanged += SelectionModeCheckedChanged;
            // SingleSelection.IsCheckedChanged   += SelectionModeCheckedChanged;
            //
            // SortAgeBtn.Click                += HandleSortAgeBtnClick;
            // ClearFiltersBtn.Click           += HandleClearFiltersBtnClick;
            // ClearFiltersAndSortersBtn.Click += HandleClearFiltersAndSortersBtnClick;
            // ColumnCheckBox1.IsChecked       =  true;
            // ColumnCheckBox2.IsChecked       =  true;
            // ColumnCheckBox3.IsChecked       =  true;
            // ColumnCheckBox4.IsChecked       =  true;
            // ColumnCheckBox5.IsChecked       =  true;
            // ColumnCheckBox6.IsChecked       =  true;
            //
            // ColumnCheckBox1.IsCheckedChanged += HandleColumnVisibleChanged;
            // ColumnCheckBox2.IsCheckedChanged += HandleColumnVisibleChanged;
            // ColumnCheckBox3.IsCheckedChanged += HandleColumnVisibleChanged;
            // ColumnCheckBox4.IsCheckedChanged += HandleColumnVisibleChanged;
            // ColumnCheckBox5.IsCheckedChanged += HandleColumnVisibleChanged;
            // ColumnCheckBox6.IsCheckedChanged += HandleColumnVisibleChanged;
        });
        InitializeComponent();
    }

    private void SelectionModeCheckedChanged(object? sender, RoutedEventArgs e)
    {
        // if (sender is RadioButton radioButton)
        // {
        //     if (radioButton == ExtendedSelection && ExtendedSelection.IsChecked.HasValue &&
        //         ExtendedSelection.IsChecked.Value)
        //     {
        //         SelectionDataGrid.SelectionMode = DataGridSelectionMode.Extended;
        //     }
        //     else if (radioButton == SingleSelection && SingleSelection.IsChecked.HasValue &&
        //              SingleSelection.IsChecked.Value)
        //     {
        //         SelectionDataGrid.SelectionMode = DataGridSelectionMode.Single;
        //     }
        // }
    }

    private void HandleColumnVisibleChanged(object? sender, RoutedEventArgs e)
    {
        // if (sender is CheckBox checkBox)
        // {
        //     var columns     = HideColumnDataGrid.Columns;
        //     var name        = checkBox.Name;
        //     var columnIndex = -1;
        //     if (name == "ColumnCheckBox1")
        //     {
        //         columnIndex = 0;
        //     }
        //     else if (name == "ColumnCheckBox2")
        //     {
        //         columnIndex = 1;
        //     }
        //     else if (name == "ColumnCheckBox3")
        //     {
        //         columnIndex = 2;
        //     }
        //     else if (name == "ColumnCheckBox4")
        //     {
        //         columnIndex = 3;
        //     }
        //     else if (name == "ColumnCheckBox5")
        //     {
        //         columnIndex = 4;
        //     }
        //     else if (name == "ColumnCheckBox6")
        //     {
        //         columnIndex = 5;
        //     }
        //
        //     if (columnIndex != -1)
        //     {
        //         var column = columns[columnIndex];
        //         column.IsVisible = checkBox.IsChecked == true;
        //     }
        // }
    }

    private void HandleSortAgeBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
      //  ResetFilterAndSortGrid.Sort(1, ListSortDirection.Descending);
    }

    private void HandleClearFiltersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
     //   ResetFilterAndSortGrid.ClearFilters();
    }

    private void HandleClearFiltersAndSortersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
        // ResetFilterAndSortGrid.ClearFilters();
        // ResetFilterAndSortGrid.ClearSort();
    }
}