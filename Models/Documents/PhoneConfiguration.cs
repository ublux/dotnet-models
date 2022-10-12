namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Configuration of a phone
/// </summary>
public partial class PhoneConfiguration : UbluxDocument, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Line keys to use
    /// </summary>
    [References(typeof(LineKeyGroup))]
    [AllowUpdate(true)]
    public string? IdLineKeyGroup { get; set; }

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    /// <summary>
    ///     Phone configuration name
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FrienlyName { get; set; }

    /// <summary>
    ///     Phone configuration description
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
