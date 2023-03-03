#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of trunk terminations ordered by priority
/// </summary>
public partial class TrunkTerminationGroup : UbluxDocument
{
    /// <summary>
    ///     Note: points to a shared_trunktermination and not a trunk termination
    ///     Example. ID of a twilio trunk to call US, then a trunk from victor to call Spain, then trunk
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(TrunkTermination))]
    [IsUbluxRequired]
    public required List<string> IdsTrunkTerminationsOrderedByPriority { get; set; } = new();
}

#endif