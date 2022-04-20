namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    [References(typeof(TrunkTermination))]
    [IsRequired]
    public List<string> IdsTrunkTerminationsOrderedByPriority
    {
        get => _IdsTrunkTerminationsOrderedByPriority;
        set { if (value is null) _IdsTrunkTerminationsOrderedByPriority.Clear(); else _IdsTrunkTerminationsOrderedByPriority = value; }
    }
    List<string> _IdsTrunkTerminationsOrderedByPriority = new();

}
