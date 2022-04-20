namespace Ublux.Communications.Models.Documents;

// ReSharper disable ConditionIsAlwaysTrueOrFalse
/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class CallerIdMask : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <summary>
    ///     Account that uses this caller id mask
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     The phone that will be used as caller id
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string PhoneNumberInternationalFormat { get; set; } = String.Empty;

    /// <summary>
    ///     Name of this caller id mask
    /// </summary>
    [AllowUpdate(true)]
    [Required]
    public string FriendlyName { get; set; } = String.Empty;

    /// <summary>
    ///     Code that user must enter to verify caller id
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string RandomVerificationCode { get; set; } = String.Empty;

    #endregion
}