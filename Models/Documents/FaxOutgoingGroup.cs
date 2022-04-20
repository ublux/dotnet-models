namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Group of faxes sent as a group via email
/// </summary>
public partial class FaxOutgoingGroup : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Id of Fax VoipNumber (virtual number) that sent the fax
    /// </summary>    
    [References(typeof(VoipNumberFax))]
        [AllowUpdate(false)]
    [Required]
    public string IdVoipNumberFax { get; set; } = String.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     There must be at least one fax attachment
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public List<FaxOutgoing> FaxesOutgoing
    {
        get => _FaxesOutgoing;
        set { if (value is null) _FaxesOutgoing.Clear(); else _FaxesOutgoing = value; }
    }
    List<FaxOutgoing> _FaxesOutgoing = new();

    /// <summary>
    ///     Email that was sent to fax@ublux.com
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public FaxEmail FaxEmail { get; set; } = new FaxEmail();

    #endregion

    /// <summary>
    ///     Phone number where fax is sent
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public string From { get; set; } = string.Empty;

    /// <summary>
    ///     If fax is sent successfully then send confirmation to this emails
    /// </summary>
        [AllowUpdate(false)]
    [Required]
    public List<string> SendConfirmationToEmails
    {
        get => _SendConfirmationToEmails;
        set { if (value is null) _SendConfirmationToEmails.Clear(); else _SendConfirmationToEmails = value; }
    }
    List<string> _SendConfirmationToEmails = new();

    /// <summary>
    ///     True if there is an error
    /// </summary>
        [AllowUpdate(false)]
    public bool ContainsError { get; set; }

    #endregion
}
