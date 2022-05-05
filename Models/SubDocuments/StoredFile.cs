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
    public int FileSizeInBytes { get; set; }

    /// <summary>
    ///     New
    ///     Md5 hash of file
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Md5Hash { get; set; } = string.Empty;

    /// <summary>
    ///     Link where it can be downloaded
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Url { get; set; } = String.Empty;

    #endregion
}
