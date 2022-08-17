#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     File stored on disk. All storedFiles will have a copy
///     This collection should not be stored on redis and be created with time to leave
/// </summary>
public partial class DiskFile : UbluxDocument
{
    /// <summary>
    ///     Id of document containing this Stored File. Example Audio1234
    /// </summary>
    [AllowUpdate(false)]
    public required string IdDocument { get; set; }

    /// <summary>
    ///     Id of stored file
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(StoredFile))]
    public required string IdStoredFile { get; set; }

    /// <summary>
    ///     Stored file such as an Audio MP3 file
    /// </summary>    
    [AllowUpdate(false)]
    public required StoredFile StoredFile { get; set; }

    /// <summary>
    ///     This property is going to only change on local mongodb. That means that one instance of mongo may have different value than another
    ///     TODO: Set index on this property
    /// </summary>
    [AllowUpdate(false)]
    public bool HasBeenDownloaded { get; set; }
}

#endif