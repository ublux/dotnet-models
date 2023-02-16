namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ublux Account
/// </summary>
public partial class Email : UbluxDocument, IReferencesTags
{
    #region Properties

    /// <summary>
    ///     Email address
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string Address { get => address; set => address = value.ToLower(); }
    private string address = "";

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

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> IdsTags { get; set; } = new();

    /// <summary>
    ///     When sending email we may send a code on the email that the user may dial from his phone to validate
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Line))]
    public Line? IdLineThatValidatedEmail { get; set; }




    #endregion


    #endregion
}
