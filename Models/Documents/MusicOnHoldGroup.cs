﻿namespace Ublux.Communications.Models.Documents;

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
    public List<string> IdsAudios { get; set; } = new();

    #endregion

    /// <summary>
    ///     Name of music on hold group
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;

    /// <summary>
    ///     Description of music on hold group
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion

}
