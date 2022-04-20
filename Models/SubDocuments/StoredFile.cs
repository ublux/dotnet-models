namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public class StoredFile : UbluxSubDocument, IReferncesAccount
{
    /// <summary>
    ///     New because we removed table account data
    ///     How big the file is
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public int FileSizeInBytes { get; set; }

    /// <summary>
    ///     New
    ///     Md5 hash of file
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string Md5Hash { get; set; } = string.Empty;

    /// <summary>
    ///     Id of account it references
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Example incoming-faxes
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string FolderName { get; set; } = String.Empty;

    /// <summary>
    ///     Usually id followed by extension. Example:  CL-I-XXXXX.mp3
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string FileName { get; set; } = String.Empty;

    ///// <summary>
    /////     Is it saved on server? It does not mean its saved on amazon
    ///// </summary>
    //public bool IsSavedOnAwsBucket { get; set; }

    /// <summary>
    ///     Link where it can be downloaded
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    public string Url { get; set; } = String.Empty;

    

   
}
