namespace Ublux.Communications.Models;

/// <summary>
///     Stored larges id global counter. Remember we generate ids of most of collections on database by incrementing this counter
/// </summary>
public class IdGlobalCounter // : IUbluxDocument Do not inherit because we do not want this model to be part of unit tests
{
    /// <summary>
    ///     Instance id. Example PBX-US-1
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.String)] // store id as string
    public required string Id { get; init; } = "";

    /// <summary>
    ///     If true application is running. we set to false when dispossing.
    ///     If app starts and this is equal to true it means application crashed!
    /// </summary>
    public bool IsRunning { get; set; } 

    /// <summary>
    ///     Actual count
    /// </summary>
    public ulong Count { get; set; }
}
