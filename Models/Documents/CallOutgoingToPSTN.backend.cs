#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to cell phone or land line
/// </summary>
public partial class CallOutgoingToPSTN : CallOutgoing
{
    /// <summary>
    ///     Trunk termination used to make phone call
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTermination))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdTrunkTermination { get; set; }
}

#endif































