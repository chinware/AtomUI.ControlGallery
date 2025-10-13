﻿using ReactiveUI;

namespace AtomUIGallery.ShowCases.ViewModels;

public class ComboBoxViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "ComboBox";
    
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = ID;
    
        
    private List<ComboBoxItemData> _comboBoxItems = [];
    
    public List<ComboBoxItemData> ComboBoxItems
    {
        get => _comboBoxItems;
        set => this.RaiseAndSetIfChanged(ref _comboBoxItems, value);
    }

    public ComboBoxViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}

public class ComboBoxItemData
{
    public string Text { get; set; } =  string.Empty;
}