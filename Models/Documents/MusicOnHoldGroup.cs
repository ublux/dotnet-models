namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Multiple audios to be used as music on hold
/// </summary>
public partial class MusicOnHoldGroup : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Audios to play meanwhile on hold
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    [IsRequired]
    public required List<string> IdsAudios { get; set; }

    #endregion

    /// <summary>
    ///     Name of music on hold group
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Description of music on hold group
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
