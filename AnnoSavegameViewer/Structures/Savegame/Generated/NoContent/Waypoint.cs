using AnnoSavegameViewer.Serialization.Core;
using System.Collections.Generic;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class Waypoint {

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public List<WaypointList> WaypointList { get; set; }

  }
}