#if UBLUX_BACKEND

namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public partial class StoredFile : UbluxSubDocument, IReferncesAccount
{
    // ID is its file name

    /// <summary>
    ///     Get id of cloud file
    /// </summary>
    public string GetIdCloudFile()
    {
        return CloudFile.BuildId(this).Id;
    }
    /// <summary>
    ///     Static implementation
    /// </summary>
    public static string GetIdCloudFile(string idStoredFile)
    {
        return CloudFile.BuildId(idStoredFile).Id;
    }

    /// <summary>
    ///     Id of account it references
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string IdAccount { get; set; }

    /// <summary>
    ///     Example incoming-faxes
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required StorageFolderName FolderName { get; set; }

    ///// <summary>
    /////     Usually id followed by extension. Example:  CL-I-XXXXX.mp3
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //[IsRequired]
    //public required string FileName { get; set; }

    /// <summary>
    ///     Server that stored this file so that other servers can download it. Example W for work. Thus it can be downloaded from w.ublux.com    
    /// </summary>
    [AllowUpdate(false)]
    public required string InstanceId { get; set; }


    /// <summary> /usr/share/ublux/accounts-files </summary>
    public static string GetTempDir(bool createDirectoryIfNotExists)
    {
        string path;
        if(Environment.OSVersion.Platform == PlatformID.Unix)
        {
            path = "/usr/share/ublux/tmp";
        }
        else
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        if (createDirectoryIfNotExists)
            if (Directory.Exists(path) == false)
                Directory.CreateDirectory(path);

        return path;
    }

    /// <summary>
    ///     Helper to get hash
    /// </summary>
    public static string GetHash(byte[] hash)
    {
        var result = new StringBuilder(hash.Length * 2);

        for (int i = 0; i < hash.Length; i++)
            result.Append(hash[i].ToString("X2"));

        return result.ToString();
    }

}

#endif