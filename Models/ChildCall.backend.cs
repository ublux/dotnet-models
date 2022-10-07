#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public abstract partial class ChildCall : ICall
{
    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public required string ChannelFrom { get; set; }

    /// <summary>
    ///     Multiple because it can ring multiple lines
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public List<string> ChannelsTo { get; set; } = new();

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? ChannelToAnswer { get; set; }
}

#endif