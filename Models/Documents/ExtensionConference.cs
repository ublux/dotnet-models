namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Parties that dial this extension will be connected
/// </summary>
public partial class ExtensionConference : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Optional audio to hear when the first participant enters the conference
    /// </summary>
    [References(typeof(Audio))]
    [AllowUpdate(true)]
    public List<string> IdsAudiosWhenOneParticipant { get; set; } = new();

    #endregion

    /// <summary>
    ///     Announce to everyone on the conference when a new participant enters the conference
    /// </summary>
    [AllowUpdate(true)]
    public bool AnnounceParticipants { get; set; }

    /// <summary>
    ///     Optional pin may be required to avoid unauthorized access to the conference
    ///     Pin is of type string because value could be 0000 and that would translate to 0 as an integer
    /// </summary>
    [AllowUpdate(true)]
    public string? Pin { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public override ExtensionType ExtensionType => ExtensionType.Conference;
}
