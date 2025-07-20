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
                BasicCaseGrid.ItemsSource                  = viewModel.BasicCaseDataSource;
                SelectionDataGrid.ItemsSource              = viewModel.BasicCaseDataSource;
                FilterAndSortGrid.ItemsSource              = viewModel.FilterAndSorterDataSource;
                FilterInTreeGrid.ItemsSource               = viewModel.FilterAndSorterDataSource;
                MultiSorterDataGrid.ItemsSource            = viewModel.MultiSorterDataSource;
                ResetFilterAndSortGrid.ItemsSource         = viewModel.BasicCaseDataSource;
                LargeSizeDataGrid.ItemsSource              = viewModel.BasicCaseDataSource;
                MiddleSizeDataGrid.ItemsSource             = viewModel.BasicCaseDataSource;
                SmallSizeDataGrid.ItemsSource              = viewModel.BasicCaseDataSource;
                CustomHeaderAndFooterDataGrid.ItemsSource  = viewModel.BasicCaseDataSource;
                ExpandableDataGrid.ItemsSource             = viewModel.ExpandableRowDataSource;
                OrderSpecificColumnDataGrid.ItemsSource    = viewModel.ExpandableRowDataSource;
                RowAndColumnHeaderDataGrid.ItemsSource     = viewModel.ExpandableRowDataSource;
                GroupHeaderDataGrid.ItemsSource            = viewModel.GroupHeaderDataSource;
                HideColumnDataGrid.ItemsSource             = viewModel.BasicCaseDataSource;
                FixedHeaderDataGrid.ItemsSource            = viewModel.FixedHeaderDataSource;
                FixedColumnsDataGrid1.ItemsSource = viewModel.FixedColumnsDataSource;
                FixedColumnsDataGrid2.ItemsSource = viewModel.FixedColumnsDataSource;
                FixedColumnsAndHeadersDataGrid.ItemsSource = viewModel.FixedColumnsAndHeadersDataSource;
                DragColumnDataGrid1.ItemsSource = viewModel.DragColumnDataSource;
                DragColumnDataGrid2.ItemsSource = viewModel.DragColumnDataSource;
                DragRowDataGrid.ItemsSource                = viewModel.DragRowDataSource;
                CustomEmptyDataGrid.ItemsSource            = viewModel.CustomEmptyDataSource;
                EditableCellsDataGrid.ItemsSource          = viewModel.EditableCellsDataSource;
            }

            ExtendedSelection.IsCheckedChanged += SelectionModeCheckedChanged;
            SingleSelection.IsCheckedChanged   += SelectionModeCheckedChanged;
            
            SortAgeBtn.Click                += HandleSortAgeBtnClick;
            ClearFiltersBtn.Click           += HandleClearFiltersBtnClick;
            ClearFiltersAndSortersBtn.Click += HandleClearFiltersAndSortersBtnClick;
            ColumnCheckBox1.IsChecked       =  true;
            ColumnCheckBox2.IsChecked       =  true;
            ColumnCheckBox3.IsChecked       =  true;
            ColumnCheckBox4.IsChecked       =  true;
            ColumnCheckBox5.IsChecked       =  true;
            ColumnCheckBox6.IsChecked       =  true;
            
            ColumnCheckBox1.IsCheckedChanged += HandleColumnVisibleChanged;
            ColumnCheckBox2.IsCheckedChanged += HandleColumnVisibleChanged;
            ColumnCheckBox3.IsCheckedChanged += HandleColumnVisibleChanged;
            ColumnCheckBox4.IsCheckedChanged += HandleColumnVisibleChanged;
            ColumnCheckBox5.IsCheckedChanged += HandleColumnVisibleChanged;
            ColumnCheckBox6.IsCheckedChanged += HandleColumnVisibleChanged;
        });
        InitializeComponent();
    }

    private void SelectionModeCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            if (radioButton == ExtendedSelection && ExtendedSelection.IsChecked.HasValue &&
                ExtendedSelection.IsChecked.Value)
            {
                SelectionDataGrid.SelectionMode = DataGridSelectionMode.Extended;
            }
            else if (radioButton == SingleSelection && SingleSelection.IsChecked.HasValue &&
                     SingleSelection.IsChecked.Value)
            {
                SelectionDataGrid.SelectionMode = DataGridSelectionMode.Single;
            }
        }
    }

    private void HandleColumnVisibleChanged(object? sender, RoutedEventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            var columns     = HideColumnDataGrid.Columns;
            var name        = checkBox.Name;
            var columnIndex = -1;
            if (name == "ColumnCheckBox1")
            {
                columnIndex = 0;
            }
            else if (name == "ColumnCheckBox2")
            {
                columnIndex = 1;
            }
            else if (name == "ColumnCheckBox3")
            {
                columnIndex = 2;
            }
            else if (name == "ColumnCheckBox4")
            {
                columnIndex = 3;
            }
            else if (name == "ColumnCheckBox5")
            {
                columnIndex = 4;
            }
            else if (name == "ColumnCheckBox6")
            {
                columnIndex = 5;
            }
        
            if (columnIndex != -1)
            {
                var column = columns[columnIndex];
                column.IsVisible = checkBox.IsChecked == true;
            }
        }
    }

    private void HandleSortAgeBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
       ResetFilterAndSortGrid.Sort(1, ListSortDirection.Descending);
    }

    private void HandleClearFiltersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
       ResetFilterAndSortGrid.ClearFilters();
    }

    private void HandleClearFiltersAndSortersBtnClick(object? sender, RoutedEventArgs? eventArgs)
    {
        ResetFilterAndSortGrid.ClearFilters();
        ResetFilterAndSortGrid.ClearSort();
    }

    private void HandleToggleEmptyGridItemsSource(object? sender, RoutedEventArgs? eventArgs)
    {
        if (CustomEmptyDataGrid.ItemsSource != null)
        {
            CustomEmptyDataGrid.ItemsSource = null;
        }
        else
        {
            if (DataContext is DataGridViewModel viewModel)
            {
                CustomEmptyDataGrid.ItemsSource = viewModel.CustomEmptyDataSource;
            }
        }
    }

    private static int CellsEditableNewRowIndex = 1;

    private void HandleAddARowToCellsEditableGrid(object? sender, RoutedEventArgs? eventArgs)
    {
        if (DataContext is DataGridViewModel viewModel)
        {
            viewModel.EditableCellsDataSource.Add(new DataGridBaseInfo()
            {
                Address = $"London, Park Lane no. {CellsEditableNewRowIndex}",
                Name    = $"Edward King {CellsEditableNewRowIndex}",
                Age     = 32
            });
            CellsEditableNewRowIndex++;
        }
    }

    private void HandleRemoveRowCellsEditableGrid(object? sender, RoutedEventArgs? eventArgs)
    {
        if (sender is PopupConfirm popupConfirm)
        {
            if (popupConfirm.DataContext is int index)
            {
                EditableCellsDataGrid.CollectionView?.RemoveAt(index);
            }
        }
    }
}