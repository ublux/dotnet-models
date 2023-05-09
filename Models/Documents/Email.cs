﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Email address. Two users may use the same email address
/// </summary>
public partial class Email : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    /// <summary>
    ///     Email address
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string Address { get => address; set => address = value.ToLower(); }
    private string address = string.Empty;

    /// <summary>
    ///     Date when email was verified
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateVerified { get; set; }

    /// <summary>
    ///     Session when email was verified. This may be null and email still be verified. DateWhenVerified is the one that determines if email is verified or not
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public UbluxSession? SessionWhenVerified { get; set; }

    /// <summary>
    ///     Is email verified?
    /// </summary>
    public bool IsVerified()
    {
        // SessionWhenVerified may be null and email still be verified.
        return DateVerified != null;
    }

    /// <summary>
    ///     Ip address where email was verified
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IpAddress { get; set; }

    #endregion
}
