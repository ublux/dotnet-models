namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class BlackListPhoneNumber : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <summary>
    ///     Account that is blocking this phone number
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Optional audio to play if call is blocked
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(false)]
    public string? IdAudioToPlayIfCallIsBlocked { get; set; }

    #endregion

    /// <summary>
    ///     The phone number that will be blocked
    /// </summary>
    [AllowUpdate(true)]
    [Required]
    public string PhoneNumber { get; set; } = String.Empty;

    /// <summary>
    ///     Friendly name of this rule
    /// </summary>
    [AllowUpdate(true)]
    [Required]
    public string FriendlyName { get; set; } = String.Empty;

    #endregion
}
