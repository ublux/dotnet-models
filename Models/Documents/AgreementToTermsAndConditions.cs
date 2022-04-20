namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

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
    [IsRequired]
    public UbluxSession UbluxSession { get; set; } = new UbluxSession();

    #endregion

    /// <summary>
    ///     Ip address of client that agreed to terms and conditions
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string Ip { get; set; } = String.Empty;

    /// <summary>
    ///     Headers of client
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string HttpRequestHeaders { get; set; } = String.Empty;

    /// <summary>
    ///     Section to terms and conditions that user agreed to
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public TermsAndConditionsCategory TermsAndConditionsCategory { get; set; }

    /// <summary>
    ///     Description of this agreement
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? Description { get; set; }

    #endregion
}
