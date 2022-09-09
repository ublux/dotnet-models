#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     File stored on the cloud
///     This collection should not be stored on redis and be created with TTL of one month
/// </summary>
public partial class CloudFile : UbluxDocument
{
    /// <summary>
    ///     Factory Pattern
    /// </summary>
    public static CloudFile Create(StoredFile sf)
    {
        return new CloudFile()
        {
            BuiltId = CloudFile.BuildId(sf),
            DateCreated = DateTime.UtcNow,
            DateDeleted = null,
            DateUpdated = null,
            IdDocument = sf.Id,
            StoredFile = sf,
            IsBackup = false,
        };
    }

    /// <summary>
    ///     Id of document containing this Stored File. Example Audio1234
    /// </summary>
    [AllowUpdate(false)]
    public required string IdDocument { get; set; }

    /// <summary>
    ///     Stored file such as an Audio MP3 file
    /// </summary>    
    [AllowUpdate(false)]
    public required StoredFile StoredFile { get; set; }

    // Remove because PBX cannot set this
    ///// <summary>
    /////     Date when stored file was uploaded to Cloud
    ///// </summary>
    //public DateTime? DateUploaded { get; set; }

    /// <summary>
    ///     Is this Cloud file backed up
    /// </summary>
    [AllowUpdate(false)]
    public required bool IsBackup { get; set; }
}

#endif