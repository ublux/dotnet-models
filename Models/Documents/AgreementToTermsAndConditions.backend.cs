#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public partial class AgreementToTermsAndConditions : UbluxDocument
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Current session when user agreed to terms and conditions. This session should contain id of user that agreed
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required UbluxSession UbluxSession { get; set; } // OK

    #endregion

    /// <summary>
    ///     Ip address of client that agreed to terms and conditions
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string Ip { get; set; } = string.Empty;

    /// <summary>
    ///     Headers of client
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string HttpRequestHeaders { get; set; } = string.Empty;

    /// <summary>
    ///     Section to terms and conditions that user agreed to
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required TermsAndConditionsCategory TermsAndConditionsCategory { get; set; }

    /// <summary>
    ///     Description of this agreement
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? Description { get; set; }

    #endregion
}

#endif