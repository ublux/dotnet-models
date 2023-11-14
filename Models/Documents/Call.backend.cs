#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux phone call
/// </summary>
public abstract partial class Call
{
    /// <summary>
    ///     Channel executing dialplan.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationRequired]
    public required string ChannelFrom { get; set; } = string.Empty;

    /// <summary>
    ///     List because a call can call multiple persons. 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public List<string> ChannelsTo { get; set; } = new();

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ChannelToAnswer { get; set; }

    /// <summary>
    ///     Mark all DateEnded as completed
    /// </summary>
    public void SetAllEndDatesToUtcNow()
    {
        var now = DateTime.UtcNow;
        DurationInSeconds ??= (now - DateCreated).TotalSeconds;

        foreach (var cc in ChildCalls)
        {
            cc.DurationInSeconds ??= (now - cc.DateCreated).TotalSeconds;
        }
    }

    /// <summary>
    ///     Get last call
    /// </summary>
    public ICall GetLastCall()
    {
        if (ChildCalls.Count == 0)
            return this;

        return ChildCalls.Last();
    }

    /// <summary>
    ///     Adds to ChannelsTo makeing sure there are not duplicates
    /// </summary>    
    public void AddToChannelsTo(string idChannel)
    {
        if (ChannelsTo.Contains(idChannel))
            return;
        ChannelsTo.Add(idChannel);
    }

    /// <summary>
    ///     Add participant phone if it does not exist
    /// </summary>
    public void AddIdParticipantPhone(string idParticipantPhone)
    {
        if(IdsParticipantPhones.Contains(idParticipantPhone)) return;
        IdsParticipantPhones.Add(idParticipantPhone);
    }
}

#endif