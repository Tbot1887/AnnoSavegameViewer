namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class LastAttacker {

    #region Public Properties

    [BinaryContent(Name = "size", NodeType = BinaryContentTypes.Attribute)]
    public object Size { get; set; }

    [BinaryContent(Name = "None", NodeType = BinaryContentTypes.Node)]
    public LastAttackerList LastAttackerList { get; set; }

    #endregion Public Properties
  }
}