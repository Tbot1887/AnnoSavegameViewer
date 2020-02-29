using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class ShareInfosList {

    [BinaryContent(Name = "Bonus", NodeType = BinaryContentTypes.Attribute)]
    public object Bonus { get; set; }

    [BinaryContent(Name = "TotalBonus", NodeType = BinaryContentTypes.Attribute)]
    public object TotalBonus { get; set; }

    [BinaryContent(Name = "ParticipantID", NodeType = BinaryContentTypes.Node)]
    public ShareInfosListParticipantID ParticipantID { get; set; }

  }
}