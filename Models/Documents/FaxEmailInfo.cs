namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
///     For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
/// </summary>
public partial class FaxEmailInfo : UbluxDocument
{
    #region Properties

    // id is the email address in lowercase

    #region References

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
    [IsRequired] /* at least one email should be received */
    public int NumberOfEmailsReceived { get; set; }

    /// <summary>
    ///     Current status of authenticating email
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public LinkFaxToEmailStatus ReplyStatus { get; set; }

    #endregion
}
