namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeDialStatus
{
    /// <summary>
    ///     If any of this dial status
    /// </summary>
    [AllowUpdate(true)]
    [BsonRepresentation(BsonType.String)]
    
    public List<DialStatus> DialStatuses { get; set; } = new();
}
