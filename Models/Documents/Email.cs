namespace Ublux.Communications.Models.Documents;

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
    ///     Ip address where email was verified
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IpAddress { get; set; }

    #region References    

    ///// <summary>
    /////     When sending email we may send a code on the email that the user may dial from his phone to validate
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[References(typeof(Line))]
    //public string IdLineThatValidatedEmail { get; set; }

    #endregion
    
    #endregion
}
