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
}

#endif