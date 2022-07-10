#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public abstract partial class ChildCall : ICall
{
    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public required string ChannelFrom { get; set; }

    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? ChannelTo { get; set; }
}

#endif