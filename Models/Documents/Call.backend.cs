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
    [IsRequired]
    public required string IdAccount { get; set; }

    /// <inheritdoc />
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public required string ChannelFrom { get; set; }
    
    /// <inheritdoc />
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string? ChannelTo { get; set; }
}

#endif