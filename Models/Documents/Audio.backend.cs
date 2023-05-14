#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public partial class Audio 
{    
    /// <summary>
    ///     Audio in sln format
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember] // client does not need to see sln format
    [UbluxValidationIsRequired]
    public required StoredFile AudioSln { get; set; }

    /// <summary>
    ///     Gets directory where to save on PBX
    /// </summary>
    public string GetDirectoryWhereToSaveOnPBX(bool createDirIfItDoesNotExist)
    {
        var path = $"/usr/share/ublux/pbx-files/audios/{this.IdAccount}";
        if (createDirIfItDoesNotExist)
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
        return path;
    }

    /// <summary>
    ///     Used for PBX to get path where audio exists
    /// </summary>
    public string GetFullPathWithoutExtension()
    {
        return Path.Combine(GetDirectoryWhereToSaveOnPBX(false), AudioSln.Id)[..^4];
    }
}

#endif