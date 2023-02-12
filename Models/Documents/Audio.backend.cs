#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc/>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [References(typeof(Account))]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     Audio in sln format
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember] // client does not need to see sln format
    [IsUbluxRequired]
    public required StoredFile AudioSln { get; set; }

    /// <summary>
    ///     Gets directory where to save on PBX
    /// </summary>
    public string GetDirectoryWhereToSaveOnPBX(bool createDirIfItDoesNotExist)
    {
        var path = $"/usr/share/ublux/audios/{this.IdAccount}";
        if (createDirIfItDoesNotExist)
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
        return path;
    }
}

#endif