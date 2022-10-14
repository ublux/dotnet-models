#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux phone call
/// </summary>
public abstract partial class Call : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    /// <inheritdoc />
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public required string ChannelFrom { get; set; } = string.Empty;

    /// <summary>
    ///     List because a call can call multiple persons. 
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public List<string> ChannelsTo { get; set; } = new();

    /// <summary>
    ///     Channel To that answered
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? ChannelToAnswer { get; set; }

    /// <summary>
    ///     Mark all DateEnded as completed
    /// </summary>
    public void SetAllEndDatesToUtcNow()
    {
        this.DateEnded ??= DateTime.UtcNow;
        
        if (this.ChildCalls != null)
        {
            foreach(var cc in this.ChildCalls)
            {
                if (cc is null)
                    continue;

                cc.DateEnded ??= DateTime.UtcNow;
            }
        }
    }
}

#endif