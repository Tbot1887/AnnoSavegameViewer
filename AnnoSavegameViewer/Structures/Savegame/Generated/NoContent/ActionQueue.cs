using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ActionQueue {

    [BinaryContent(Name = "TimeEventHeap", NodeType = BinaryContentTypes.Node)]
    public TimeEventHeap TimeEventHeap { get; set; }

    [BinaryContent(Name = "IDManager", NodeType = BinaryContentTypes.Node)]
    public ActionQueueIDManager IDManager { get; set; }

  }
}