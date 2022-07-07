#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     Points to what account?
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }

    /// <summary>
    ///     Password of phone used to authenticate with asterisk
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public required string Password { get; set; }
}

#endif