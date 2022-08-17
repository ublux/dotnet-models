namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public partial class StoredFile : UbluxSubDocument
{
    #region Properties    

    /// <summary>
    ///     New because we removed table account data
    ///     How big the file is
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required int FileSizeInBytes { get; set; }

    /// <summary>
    ///     Md5 hash of file
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Md5Hash { get; set; }

    /// <summary>
    ///     Link where it can be downloaded. Example: https://api.ublux.com/StoredFile/Ac.1/audios/SF.xxxxxxxx.mp3
    /// </summary>
    [AllowUpdate(false)]
    [BsonIgnore] // do not store on mongo
    public string Url => BuildUrl(this.ApiDomain, this.Id);

    /// <summary>
    ///     Helper method to build URL
    /// </summary>
    public static string BuildUrl(string apiDomain, string idStoredFile)
    {
        return $"https://{apiDomain}/{nameof(StoredFile)}/{GetIdDiskFile(idStoredFile)}";
    }    


    /// <summary>
    ///     Thanks to this domain url can be built
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string ApiDomain { get; set; }

    #endregion
}
