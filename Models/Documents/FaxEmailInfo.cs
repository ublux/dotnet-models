﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
///     For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
/// </summary>
public partial class FaxEmailInfo : UbluxDocument, IReferencesTags
{
    #region Properties

    // id is the email address in lowercase

    #region References

    /// <summary>
    ///     If email was validated with phone then what line validated this email?
    ///     Line that validated email
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [References(typeof(Line))]
    public Line? LineThatValidatedEmail { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> IdsTags { get; set; } = new();

    #endregion

    /// <summary>
    ///     Number of emails received
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired] /* at least one email should be received */
    public required int NumberOfEmailsReceived { get; set; }

    /// <summary>
    ///     Current status of authenticating email
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required LinkFaxToEmailStatus ReplyStatus { get; set; }

    #endregion
}
