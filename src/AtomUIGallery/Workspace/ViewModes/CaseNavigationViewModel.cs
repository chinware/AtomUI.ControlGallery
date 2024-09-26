using AtomUIGallery.ShowCases.ViewModels;
using ReactiveUI;

namespace AtomUIGallery.Workspace.ViewModes;

public class CaseNavigationViewModel : ReactiveObject
{
    private Dictionary<string, Func<IRoutableViewModel>> _showCaseViewModelFactories;
    public IScreen HostScreen { get; }

    public CaseNavigationViewModel(IScreen hostScreen)
    {
        _showCaseViewModelFactories = new Dictionary<string, Func<IRoutableViewModel>>();
        HostScreen                  = hostScreen;
    }

    private void RegisterShowCaseViewModels()
    {
        _showCaseViewModelFactories.Add(PaletteShowCaseViewModel.ID, () => new PaletteShowCaseViewModel(HostScreen));
    }
}