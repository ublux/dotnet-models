namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of line keys
/// </summary>
public partial class LineKeyGroup : UbluxDocument
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Group of speed dial keys. Must have at least one
    /// </summary>
    [AllowUpdate(true)]
    public List<LineKey> LineKeys { get; set; } = new();

    #endregion

    /// <summary>
    ///     Friendly name of line key group
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Description of line key group
    /// </summary>

    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
