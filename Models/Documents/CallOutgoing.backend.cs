#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Outgoing phone call
/// </summary>
public abstract partial class CallOutgoing : Call
{
    /// <summary>
    ///     Channel making call. Probably channel that is executing dialplan
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string ChannelFrom { get; set; } = string.Empty;

    /// <summary>
    ///     Connected channel
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? ChannelTo { get; set; }
}

#endif