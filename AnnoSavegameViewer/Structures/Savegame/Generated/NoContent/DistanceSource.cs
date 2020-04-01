using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DistanceSource {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public DistanceSourceValue Value { get; set; }

  }
}