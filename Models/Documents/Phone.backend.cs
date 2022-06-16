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
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Password of phone used to authenticate with asterisk
    /// </summary>
    [IsRequired]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public string Password { get; set; } = String.Empty;
}

#endif