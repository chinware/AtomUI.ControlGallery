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
            new DataGridBaseInfo("1", "John Brown", 32, "New York No. 1 Lake Park", ["nice", "developer"]),
            new DataGridBaseInfo("2", "Jim Green", 42, "London No. 1 Lake Park", ["loser"]),
            new DataGridBaseInfo("3", "Joe Black", 32, "Sydney No. 1 Lake Park", ["cool", "teacher"])
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
    public List<string> Tags { get; set; }

    public DataGridBaseInfo(string key, string name, int age, string address, List<string> tags)
    {
        Key = key;
        Name = name;
        Age = age;
        Address = address;
        Tags = tags;
    }
}