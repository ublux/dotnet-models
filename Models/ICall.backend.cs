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
    public List<string> ChannelsTo { get; set; }

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? ChannelToAnswer { get; set; }

    /// <summary>
    ///     Adds to ChannelsTo makeing sure there are not duplicates
    /// </summary>    
    public void AddToChannesTo(string idChannel);
}

#endif