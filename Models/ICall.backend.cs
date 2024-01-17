using System.Collections.Concurrent;

#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial interface ICall
{
    /// <summary>
    ///     Channel making call. Probably channel that is executing dialplan
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string ChannelFrom { get; set; }

    /// <summary>
    ///     List because a line can ring multiple lines
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]
    public ConcurrentBag<string> ChannelsTo { get; set; }

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ChannelToAnswer { get; set; }
    
    /// <summary>
    ///     Custom AI features. For example determine if agent is speaking to fast
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public CompletedAiExtensionFeatures? CompletedAiExtensionFeatures { get; set; }

    /// <summary>
    ///     Adds to ChannelsTo making sure there are not duplicates
    /// </summary>    
    public void AddToChannelsTo(string idChannel);
}

#endif