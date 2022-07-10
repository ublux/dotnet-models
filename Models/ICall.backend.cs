#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial interface ICall
{
    /// <summary>
    ///     Channel making call. Probably channel that is executing dialplan
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string ChannelFrom { get; set; }

    /// <summary>
    ///     Connected channel
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? ChannelTo { get; set; }
}

#endif