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
    [IsUbluxRequired]
    public required string IdAccount { get; set; }   

    #endregion

    /// <summary>
    ///     Audio in sln format
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember] // client does not need to see sln format
    [IsUbluxRequired]
    public required StoredFile AudioSln { get; set; }

    
}

#endif