#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [References(typeof(Account))]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     Audio in sln format
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember] // client does not need to see sln format
    [IsRequired]
    public StoredFile AudioSln { get; set; } = new StoredFile();
}

#endif