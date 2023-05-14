namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
[BsonIgnoreExtraElements]
public partial class StoredFile : UbluxSubDocument
{
    #region Properties    

    // Not used because its a subdocument
    ///// <summary>
    /////     Ids of tags
    ///// </summary>
    //[AllowUpdate(true)]
    //[References(typeof(Tag))]
    //public List<string> IdsTags { get; set; }  = new();

    /// <summary>
    ///     New because we removed table account data
    ///     How big the file is
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required int FileSizeInBytes { get; set; }

    /// <summary>
    ///     Md5 hash of file
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    public required string Md5Hash { get; set; }

    /// <summary>
    ///     Link where it can be downloaded. Example: https://api.ublux.com/StoredFile/Ac.1/audios/SF.xxxxxxxx.mp3
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [BsonIgnore] // do not store on mongo
    public string Url => BuildUrl(Constants.WebService_BaseUrl, this.Id);

    /// <summary>
    ///     helper method to build url
    /// </summary>
    public static string BuildUrl(string webserviceBaseUrl, string idstoredfile)
    {
        return $"{webserviceBaseUrl}/{nameof(StoredFile)}/{idstoredfile}";
    }
    
    #endregion
}
