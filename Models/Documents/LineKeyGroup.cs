namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Group of line keys
/// </summary>
public partial class LineKeyGroup : UbluxDocument, IReferncesAccount
{
    

    #region Properties

    #region References

    /// <inheritdoc/>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Group of speed dial keys. Must have at least one
    /// </summary>
        [AllowUpdate(true)]
    public List<LineKey> LineKeys
    {
        get => _LineKeys;
        set { if (value is null) _LineKeys.Clear(); else _LineKeys = value; }
    }
    List<LineKey> _LineKeys = new();

    #endregion

    /// <summary>
    ///     Friendly name of line key group
    /// </summary>
        [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Description of line key group
    /// </summary>

        [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
