namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
///     For example email a.namnum@gmail.com will send faxes through VoipFax with id XXXX-XXXX
/// </summary>
public partial class FaxEmailInfo : UbluxDocument, IReferncesAccount
{
    #region Properties

    // _id is the email address in lowercase

    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    ///// <summary>
    /////     Default fax did where to send faxes from. It can be null. If null we will send faxes from first FaxDiD found on account
    ///// </summary>
    //[References(typeof(VoipNumberFax))]
    //[AllowUpdate(false)]
    //    //public string? IdVoipNumberFaxDefault { get; set; }

    /// <summary>
    ///     If email was validated with phone then what line validated this email?
    ///     Id of line that validated email
    /// </summary>
    [AllowUpdate(false)]
        [References(typeof(Line))]
    public string? IdLineThatValidatedEmail { get; set; }

    #endregion

    /// <summary>
    ///     Number of emails received
    /// </summary>
    [AllowUpdate(false)]
        [Required] /* at least one email should be received */
    public int NumberOfEmailsReceived { get; set; }

    /// <summary>
    ///     Current status of authenticating email
    /// </summary>
    [AllowUpdate(false)]
        [Required]
    public LinkFaxToEmailStatus ReplyStatus { get; set; }

    /// <summary>
    ///     It is a 4 digit random code that the user must call in his Ublux phone in order to identify his identity.
    ///     The code the user dials will start with *9 followed by this 4 digit number
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public int IdentificationToken { get; set; }

    /// <summary>
    ///     Needed because identification token expires. IdentificationToken should be valid for 5 minutes
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public string DateIdentificationTokenCreated { get; set; } = String.Empty;

    /// <summary>
    ///     If someone sends a lot of emails without reading the instructions it will be marked as spam
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public bool IsSpam { get; set; }

    /// <summary>
    ///     The first time the user sends a fax we explain that he has to wait for a confirmation
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    public bool HaveWeSentEmailExplainingUserHasToWaitForConfirmation { get; set; }

    #endregion
}
