#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public abstract partial class ChildCall : ICall
{
    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public required string ChannelFrom { get; set; }

    /// <summary>
    ///     Multiple because it can ring multiple lines
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public List<string> ChannelsTo { get; set; } = new();

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public string? ChannelToAnswer { get; set; }

    /// <summary>
    ///     Call duration in seconds
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double? DurationInSeconds { get; set; }
}

#endif