using System.Text.Json.Serialization;
using PixiDocks.Core.Serialization;

namespace PixiDocks.Core.Docking;

[JsonConverter(typeof(DockableTreeConverter))]
public interface IDockableTree : IDockableLayoutElement
{
    public ITreeElement First { get; set; }
    public ITreeElement Second { get; set; }
    public DockingDirection? SplitDirection { get; set; }
}