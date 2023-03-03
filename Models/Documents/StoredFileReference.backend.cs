#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     File stored on the cloud
///     This collection should not be stored on redis and be created with TTL
///     Thanks to this collection we can keep track of all StoredFiles
/// </summary>
public partial class StoredFileReference : UbluxDocument
{
    /// <summary>
    ///     Factory Pattern
    /// </summary>
    public static StoredFileReference Create(StoredFile sf, string idParentDocument)
    {
        return new StoredFileReference()
        {
            BuiltId = StoredFileReference.BuildId(sf),
            DateCreated = DateTime.UtcNow,
            DateDeleted = null,
            IdDocument = idParentDocument,
            StoredFile = sf,
            IsBackup = false,
        };
    }

    /// <summary>
    ///     Id of document containing this Stored File. It should be the parent document not the SotedFileObject!
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdDocument { get; set; } = string.Empty;

    /// <summary>
    ///     Stored file such as an Audio MP3 file
    /// </summary>    
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required StoredFile StoredFile { get; set; }

    /// <summary>
    ///     Is this Cloud file backed up
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public required bool IsBackup { get; set; }
}

#endif