using System.Windows.Input;

namespace PixiDocks.Core;

public interface IDockableHost
{
    public IDockContext Context { get; }
    public IReadOnlyCollection<IDockable> Dockables { get;}
    public IDockable ActiveDockable { get; set; }
    public void AddDockable(IDockable dockable);
    public void RemoveDockable(IDockable dockable);
    public bool IsDockableWithin(int x, int y);
    public void OnDockableEntered(IDockable dockable);
    public void OnDockableOver(IDockable dockable);
    public void OnDockableExited(IDockable dockable);
}