using AnnoSavegameViewer.Serialization.Core;

namespace AnnoSavegameViewer.Structures.Savegame.Generated {

  public class FirstTrainMessageSentList {

    [BinaryContent(Name = "value", NodeType = BinaryContentTypes.Node)]
    public FirstTrainMessageSentListValue Value { get; set; }

  }
}