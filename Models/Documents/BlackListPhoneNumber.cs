﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class BlackListPhoneNumber : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Optional audio to play if call is blocked
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public string? IdAudioToPlayIfCallIsBlocked { get; set; }   

    #endregion    

    /// <summary>
    ///     The phone number that will be blocked
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string Number { get; set; }

    /// <summary>
    ///     Friendly name of this rule
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    #endregion
}
