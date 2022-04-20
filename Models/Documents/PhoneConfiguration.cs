namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Configuration of a phone
/// </summary>
public partial class PhoneConfiguration : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Line keys to use
    /// </summary>
        [References(typeof(LineKeyGroup))]
    [AllowUpdate(true)]
    public string? IdLineKeyGroup { get; set; }

    #endregion

    /// <summary>
    ///     Phone configuration name
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public string FrienlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Phone configuration description
    /// </summary>
        [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
