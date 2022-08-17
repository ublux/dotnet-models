#if UBLUX_BACKEND

namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public partial class StoredFile : UbluxSubDocument, IReferncesAccount
{
    /// <summary>
    ///     Get id of disk file
    /// </summary>
    public string GetIdDiskFile()
    {
        return DiskFile.BuildId(this).Id;
    }
    /// <summary>
    ///     Static implementation
    /// </summary>
    public static string GetIdDiskFile(string idStoredFile)
    {
        return DiskFile.BuildId(idStoredFile).Id;
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

    /// <summary>
    ///     Usually id followed by extension. Example:  CL-I-XXXXX.mp3
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public required string FileName { get; set; }

    /// <summary>
    ///     Server that stored this file so that other servers can download it. Example W for work. Thus it can be downloaded from w.ublux.com    
    /// </summary>
    [AllowUpdate(false)]
    public required string InstanceId { get; set; }
    
    /// <summary>
    ///     Get id
    /// </summary>
    /// <returns></returns>
    public string GetKey()
    {
        return $"{IdAccount}/{FolderName}/{FileName}";
    }

    /// <summary>
    ///     Get location where it will be stored on file system
    /// </summary>
    public static string GetDirectoryWhereToSaveOnLinux(string idAccount, StorageFolderName folderName)
    {
        return $"{GetDirectoryWhereToSaveOnLinuxBase()}/{idAccount}/{folderName}";
    }
    /// <summary>
    ///     Get location where it will be stored on file system
    /// </summary>
    public string GetPathWhereToSaveOnLinux()
    {
        return System.IO.Path.Combine(GetDirectoryWhereToSaveOnLinux(this.IdAccount, this.FolderName), this.Id);
    }

    /// <summary> Get base directory where to save accounts data </summary>
    public static string GetDirectoryWhereToSaveOnLinuxBase() => "/usr/share/ublux/accounts-data";

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