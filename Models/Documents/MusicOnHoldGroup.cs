namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Multiple audios to be used as music on hold
/// </summary>
public partial class MusicOnHoldGroup : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Audios to play meanwhile on hold
    /// </summary>
        [References(typeof(Audio))]
    [AllowUpdate(true)]
    [Required]
    public List<string> IdsAudios
    {
        get => _IdsAudios;
        set { if (value is null) _IdsAudios.Clear(); else _IdsAudios = value; }
    }
    List<string> _IdsAudios = new();

    #endregion

    /// <summary>
    ///     Name of music on hold group
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public string FriendlyName { get; set; } = String.Empty;

    /// <summary>
    ///     Description of music on hold group
    /// </summary>
        [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
