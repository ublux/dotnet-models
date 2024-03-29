﻿#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     File stored on the cloud
///     Thanks to this collection we can keep track of all StoredFiles
/// </summary>
public partial class StoredFileReference : UbluxDocument_ReferenceAccount
{
    /// <summary>
    ///     Factory Pattern
    /// </summary>
    public static StoredFileReference Create(StoredFile sf, string idParentDocument)
    {
        return new StoredFileReference
        {
            BuiltId = BuildId(sf),
            DateCreated = DateTime.UtcNow,
            DateDeleted = null,
            IdDocument = idParentDocument,
            StoredFile = sf,
            IsBackup = false,
            IdAccount = sf.IdAccount
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
    ///     True means its backed up. False means its not
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool IsBackup { get; set; }

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by id of document
        yield return new MongoDbIndex(collection, nameof(IdDocument))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}

#endif