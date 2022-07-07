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
    ///     New
    ///     Md5 hash of file
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Md5Hash { get; set; }

    /// <summary>
    ///     Link where it can be downloaded
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string Url { get; set; }

    #endregion
}
