#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Extension could be of type basic,queue,conference,voicemail or callFlow
/// </summary>
public abstract partial class Extension : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public required string IdAccount { get; set; }
}

#endif