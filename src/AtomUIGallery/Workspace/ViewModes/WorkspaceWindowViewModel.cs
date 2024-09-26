using ReactiveUI;

namespace AtomUIGallery.Workspace.ViewModes;

public class WorkspaceWindowViewModel : ReactiveObject, IScreen
{
    public RoutingState Router { get; } = new RoutingState();
}