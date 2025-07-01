using System.Collections.ObjectModel;
using AtomUI.Controls;
using DynamicData;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public partial class DataGridViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DataGridShowCase";

    public IScreen HostScreen { get; }

    public string UrlPathSegment { get; } = ID;

    public ObservableCollection<DataGridBaseInfo> BasicCaseDataSource { get; }
    public ObservableCollection<DataGridBaseInfo> FilterAndSorterDataSource { get; }
    public ObservableCollection<MultiSorterDataType> MultiSorterDataSource { get; }
    public ObservableCollection<ExpandableRowDataType> ExpandableRowDataSource { get; }

    public DataGridViewModel(IScreen screen)
    {
        HostScreen                = screen;
        BasicCaseDataSource       = new ObservableCollection<DataGridBaseInfo>();
        FilterAndSorterDataSource = new ObservableCollection<DataGridBaseInfo>();
        MultiSorterDataSource     = new ObservableCollection<MultiSorterDataType>();
        ExpandableRowDataSource   = new ObservableCollection<ExpandableRowDataType>();
        InitBasicShowCaseDataSource();
        InitFilterAndSorterDataSource();
        InitMultiSorterDataSource();
        InitExpandableRowDataSource();
    }

    private void InitBasicShowCaseDataSource()
    {
        List<DataGridBaseInfo> items =
        [
            new DataGridBaseInfo
            {
                Key   = "1", Name = "John Brown", Age = 32, Address = "New York No. 1 Lake Park",
                Money = "￥300,000.00",
                Tags =
                [
                    new TagInfo { Name = "NICE", Color      = "green" },
                    new TagInfo { Name = "DEVELOPER", Color = "geekblue" }
                ]
            },
            new DataGridBaseInfo
            {
                Key   = "2", Name = "Jim Green", Age = 42, Address = "London No. 1 Lake Park",
                Money = "￥1,256,000.00",
                Tags =
                [
                    new TagInfo { Name = "LOSER", Color = "volcano" }
                ]
            },
            new DataGridBaseInfo
            {
                Key   = "3", Name = "Joe Black", Age = 32, Address = "Sydney No. 1 Lake Park",
                Money = "￥120,000.00",
                Tags =
                [
                    new TagInfo { Name = "COOL", Color    = "green" },
                    new TagInfo { Name = "TEACHER", Color = "geekblue" }
                ]
            }
        ];
        BasicCaseDataSource.AddRange(items);
    }

    private void InitFilterAndSorterDataSource()
    {
        List<DataGridBaseInfo> items =
        [
            new DataGridBaseInfo { Key = "1", Name = "John Brown", Age = 32, Address = "New York No. 1 Lake Park" },
            new DataGridBaseInfo { Key = "2", Name = "Jim Green", Age  = 42, Address = "London No. 1 Lake Park" },
            new DataGridBaseInfo { Key = "3", Name = "Joe Black", Age  = 32, Address = "Sydney No. 1 Lake Park" },
            new DataGridBaseInfo { Key = "4", Name = "Joe Red", Age    = 32, Address = "London No. 2 Lake Park" }
        ];
        FilterAndSorterDataSource.AddRange(items);
    }

    private void InitMultiSorterDataSource()
    {
        List<MultiSorterDataType> items =
        [
            new MultiSorterDataType { Key = "1", Name = "John Brown", Chinese = 98, Math = 60, English = 70 },
            new MultiSorterDataType { Key = "2", Name = "Jim Green", Chinese  = 98, Math = 66, English = 89 },
            new MultiSorterDataType { Key = "3", Name = "Joe Black", Chinese  = 98, Math = 90, English = 70 },
            new MultiSorterDataType { Key = "3", Name = "Jim Red", Chinese    = 88, Math = 99, English = 89 },
        ];
        MultiSorterDataSource.AddRange(items);
    }

    private void InitExpandableRowDataSource()
    {
        List<ExpandableRowDataType> items =
        [
            new ExpandableRowDataType
            {
                Key = "1", Name = "John Brown", Age = 32, Address = "New York No. 1 Lake Park",
                Description = "My name is John Brown, I am 32 years old, living in New York No. 1 Lake Park."
            },
            new ExpandableRowDataType
            {
                Key = "2", Name = "Jim Green", Age  = 42, Address = "London No. 1 Lake Park",
                Description = "London No. 1 Lake Park"
            },
            new ExpandableRowDataType
            {
                Key = "3", Name = "Joe Black", Age  = 32, Address = "Sydney No. 1 Lake Park",
                Description = "My name is Joe Black, I am 32 years old, living in Sydney No. 1 Lake Park."
            },
            new ExpandableRowDataType
            {
                Key = "5", Name = "Joe Red", Age    = 78, Address = "London No. 2 Lake Park",
                Description = "My name is Joe Black, I am 78 years old, London No. 2 Lake Park"
            }
        ];
        ExpandableRowDataSource.AddRange(items);
    }
}

public class DataGridBaseInfo
{
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Money { get; set; } = string.Empty;
    public List<TagInfo> Tags { get; set; } = new();
}

public class TagInfo
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
}

public class MultiSorterDataType
{
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Chinese { get; set; }
    public int Math { get; set; }
    public int English { get; set; }
}

public class ExpandableRowDataType : DataGridBaseInfo
{
    public string Description { get; set; } = string.Empty;
}