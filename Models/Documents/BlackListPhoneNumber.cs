﻿namespace Ublux.Communications.Models.Documents;

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
    public string Number { get; set; } = String.Empty;

    /// <summary>
    ///     Friendly name of this rule
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;

    #endregion
}
