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
        this.DurationInSeconds ??= (now - this.DateCreated).TotalSeconds;

        if (this.ChildCalls != null)
        {
            foreach (var cc in this.ChildCalls)
            {
                if (cc is null)
                    continue;

                cc.DurationInSeconds ??= (now - cc.DateCreated).TotalSeconds;
            }
        }
    }

    /// <summary>
    ///     Get last call
    /// </summary>
    public ICall GetLastCall()
    {
        if (this.ChildCalls is null || this.ChildCalls.Count == 0)
            return this;

        return this.ChildCalls.Last();
    }

    /// <summary>
    ///     Adds to ChannelsTo makeing sure there are not duplicates
    /// </summary>    
    public void AddToChannesTo(string idChannel)
    {
        if (ChannelsTo.Contains(idChannel))
            return;
        ChannelsTo.Add(idChannel);
    }
}

#endif