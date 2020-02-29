using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class DiscoveredParticipants {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<DiscoveredParticipantsList> DiscoveredParticipantsList { get; set; }

  }
}