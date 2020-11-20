namespace AnnoSavegameViewer.Structures.Savegame.Generated {
  using AnnoSavegameViewer.Serialization.Core;

  public class AllRequestsList {

    [BinaryContent(Name = "Product", NodeType = BinaryContentTypes.Attribute)]
    public object Product { get; set; }

    [BinaryContent(Name = "RequestingSession", NodeType = BinaryContentTypes.Attribute)]
    public object RequestingSession { get; set; }

    [BinaryContent(Name = "TargetSession", NodeType = BinaryContentTypes.Attribute)]
    public object TargetSession { get; set; }

    [BinaryContent(Name = "Status", NodeType = BinaryContentTypes.Attribute)]
    public object Status { get; set; }

    [BinaryContent(Name = "Priority", NodeType = BinaryContentTypes.Node)]
    public AllRequestsListPriority Priority { get; set; }

    [BinaryContent(Name = "Source", NodeType = BinaryContentTypes.Node)]
    public AllRequestsListSource Source { get; set; }
  }
}