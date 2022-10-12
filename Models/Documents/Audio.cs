namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio : UbluxDocument, IReferencesTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Audio in mp3 format
    /// </summary>
    [AllowUpdate(false)]
    public StoredFile? AudioMp3 { get; set; }

    /// <summary>
    ///     Audio in wav format
    /// </summary>
    [AllowUpdate(false)]
    public required StoredFile? AudioWav { get; set; }

    #endregion

    /// <summary>
    ///     Name of audio
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }

    /// <summary>
    ///     Duration of audio in seconds
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest]
    public required int DurationInSeconds { get; set; }

    /// <summary>
    ///     Description of audio
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion
}
