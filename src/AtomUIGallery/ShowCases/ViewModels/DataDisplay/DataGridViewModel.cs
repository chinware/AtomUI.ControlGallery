using System.Collections.ObjectModel;
using DynamicData;
using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public partial class DataGridViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "DataGridShowCase";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
    public ObservableCollection<DataGridBaseInfo> BasicCaseDataSource { get; }

    public DataGridViewModel(IScreen screen)
    {
        HostScreen = screen;
        BasicCaseDataSource = new ObservableCollection<DataGridBaseInfo>();
        InitBasicShowCaseDataSource();
    }

    private void InitBasicShowCaseDataSource()
    {
        List<DataGridBaseInfo> items = [
            new DataGridBaseInfo("1", "John Brown", 32, "New York No. 1 Lake Park", 
                [
                    new TagInfo() { Name = "NICE", Color = "green"},
                    new TagInfo() { Name = "DEVELOPER", Color = "geekblue"}
                ]),
            new DataGridBaseInfo("2", "Jim Green", 42, "London No. 1 Lake Park", 
                [
                    new TagInfo() { Name = "LOSER", Color = "volcano"}
                ]),
            new DataGridBaseInfo("3", "Joe Black", 32, "Sydney No. 1 Lake Park", 
                [
                    new TagInfo() { Name = "COOL", Color      = "green"},
                    new TagInfo() { Name = "TEACHER", Color = "geekblue"}
                ])
        ];
        BasicCaseDataSource.AddRange(items);
    }
}

public class DataGridBaseInfo
{
    public string Key { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public List<TagInfo> Tags { get; set; }

    public DataGridBaseInfo(string key, string name, int age, string address, List<TagInfo> tags)
    {
        Key = key;
        Name = name;
        Age = age;
        Address = address;
        Tags = tags;
    }
}

public class TagInfo
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
}