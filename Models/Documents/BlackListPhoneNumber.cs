namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class BlackListPhoneNumber : UbluxDocument
{
    #region Properties

    #region References

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
    [IsRequired]
    public required string Number { get; set; }

    /// <summary>
    ///     Friendly name of this rule
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    #endregion
}
