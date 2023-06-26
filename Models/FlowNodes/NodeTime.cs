namespace Ublux.Communications.Models.FlowNodes;

/// <summary></summary>
public partial class NodeTime
{
    /// <summary>
    ///     Start time in 24 hour format. Example 14:00
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    ///     Start time in 24 hour format. Example 16:30
    /// </summary>
    public required string EndTime { get; set; }
}

public partial class NodeAPI
{

}

public partial class NodeCallBackAPI
{

}

public partial class NodeDialStatus
{
    /// <summary>
    ///     If any of this dial status
    /// </summary>
    [AllowUpdate(true)]
    [BsonRepresentation(BsonType.String)]
    
    public List<DialStatus> DialStatuses { get; set; } = new();
}
