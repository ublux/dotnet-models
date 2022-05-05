namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Configuration of a phone
/// </summary>
public partial class PhoneConfiguration : UbluxDocument
{
    #region Properties

    #region References

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
    [IsRequired]
    public string FrienlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Phone configuration description
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
