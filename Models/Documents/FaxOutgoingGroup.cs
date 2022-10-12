namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of faxes sent as a group via email
/// </summary>
public partial class FaxOutgoingGroup : UbluxDocument, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of Fax VoipNumber (virtual number) that sent the fax
    /// </summary>    
    [References(typeof(VoipNumberFax))]
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string IdVoipNumberFax { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     There must be at least one fax attachment
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public List<FaxOutgoing> FaxesOutgoing { get; set; } = new();

    /// <summary>
    ///     Email that was sent to fax@ublux.com
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required FaxEmail FaxEmail { get; set; }

    #endregion

    /// <summary>
    ///     Phone number where fax is sent
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string From { get; set; }

    /// <summary>
    ///     If fax is sent successfully then send confirmation to this emails
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required List<string> SendConfirmationToEmails { get; set; }

    /// <summary>
    ///     True if there is an error
    /// </summary>
    [AllowUpdate(false)]
    public bool ContainsError { get; set; }

    #endregion
}
