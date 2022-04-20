namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [References(typeof(Account))]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

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
    public StoredFile? AudioWav { get; set; }

    /// <summary>
    ///     Audio in sln format
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember] // client does not need to see sln format
    [IsRequired]
    public StoredFile AudioSln { get; set; } = new StoredFile();

    #endregion

    /// <summary>
    ///     Name of audio
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;

    /// <summary>
    ///     Duration of audio in seconds
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    [HideForCreateRequest]
    public int DurationInSeconds { get; set; }

    /// <summary>
    ///     Description of audio
    /// </summary>
    [AllowUpdate(true)]
    public string? Description { get; set; }

    #endregion

}
