#if UBLUX_BACKEND


using static Ublux.Communications.Models.Constants;

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
    [UbluxValidationRequired]
    public required StoredFile AudioSln { get; set; }

    /// <summary>
    ///     Gets directory where to save on PBX. Example: /usr/share/ublux/pbx-files/audios/Ac.1
    /// </summary>
    public static string GetDirectoryWhereToSaveOnPBX(string idAccount, bool createDirIfItDoesNotExist)
    {
        // Example: /usr/share/ublux/pbx-files/audios/Ac.1
        var path = Path.Combine(Pbx.PathAudios, idAccount);
        if (createDirIfItDoesNotExist)
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);
        return path;
    }
    /// <summary>
    ///     None static version
    /// </summary>
    public string GetDirectoryWhereToSaveOnPBX(bool createDirIfItDoesNotExist)
    {
        return GetDirectoryWhereToSaveOnPBX(this.IdAccount, createDirIfItDoesNotExist);
    }

    /// <summary>
    ///     Gets path where to save on pbx. Example: /usr/share/ublux/pbx-files/audios/Ac.1/XXXXXX.sln
    /// </summary>
    public static string GetPathWhereToSaveOnPBX(string idAccount, bool createDirIfItDoesNotExist, string idAudioSln)
    {
        var dirWhereToSave = GetDirectoryWhereToSaveOnPBX(idAccount, createDirIfItDoesNotExist);
        return Path.Combine(dirWhereToSave, idAudioSln);
    }

    /// <summary>
    ///     Used for PBX to get path where audio exists.
    ///     idAudioSln = AudioSln.Id
    /// </summary>
    public static string GetFullPathWithoutExtension(string idAccount, string idAudioSln)
    {
        return GetPathWhereToSaveOnPBX(idAccount, false, idAudioSln)[..^4];
    }
    /// <summary>
    ///     Call static method using this audio
    /// </summary>
    public string GetFullPathWithoutExtension()
    {
        return GetFullPathWithoutExtension(this.IdAccount, this.AudioSln.Id);
    }
}

#endif