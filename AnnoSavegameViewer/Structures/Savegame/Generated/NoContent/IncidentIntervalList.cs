using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class IncidentIntervalList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public IncidentIntervalListValue Value { get; set; }

  }
}