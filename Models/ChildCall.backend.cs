using System.Collections.Concurrent;

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
    public ConcurrentBag<string> ChannelsTo { get; set; } = [];

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
    
    /// <summary>
    ///     Custom AI features. For example determine if agent is speaking to fast
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public CompletedAiExtensionFeatures? CompletedAiExtensionFeatures { get; set; }

    /// <summary>
    ///     Adds to ChannelsTo making sure there are not duplicates
    /// </summary>    
    public void AddToChannelsTo(string idChannel)
    {
        if (ChannelsTo.Contains(idChannel))
            return;
        ChannelsTo.Add(idChannel);
    }
}

#endif