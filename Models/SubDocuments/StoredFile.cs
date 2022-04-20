namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public class StoredFile : UbluxSubDocument, IReferncesAccount
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
    ///     Id of account it references
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Example incoming-faxes
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string FolderName { get; set; } = String.Empty;

    /// <summary>
    ///     Usually id followed by extension. Example:  CL-I-XXXXX.mp3
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [IsRequired]
    public string FileName { get; set; } = String.Empty;

    ///// <summary>
    /////     Is it saved on server? It does not mean its saved on amazon
    ///// </summary>
    //public bool IsSavedOnAwsBucket { get; set; }

    /// <summary>
    ///     Link where it can be downloaded
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Url { get; set; } = String.Empty;

    #endregion

    ///// <inheritdoc />
    //public override string SubDocumentPrefix() => "SubSF";

    ///// <inheritdoc />
    //public override void SetId() => _id = $"{UCore.InstanceId}:{SubDocumentPrefix()}:{DateTime.UtcNow.ToUnixEpoch()}:{Interlocked.Increment(ref DomainGlobals.IdGenerationCounter)}";

    /// <summary>
    ///     Common folders where we store files
    /// </summary>
    public static class CommonFolderNames
    {
        /// <summary></summary>
        public const string Voicemail = "voicemails";
        /// <summary></summary>
        public const string FaxesIncoming = "faxes-incoming";
        /// <summary></summary>
        public const string FaxesOutgoing = "faxes-outgoing";
        /// <summary></summary>
        public const string Audios = "audios";
        /// <summary></summary>
        public const string Recordings = "recordings";
    }

    /// <summary>
    ///     Get id
    /// </summary>
    /// <returns></returns>
    public string GetKey()
    {
        return $"{IdAccount}/{FolderName}/{FileName}";
    }

    /// <summary>
    ///     Get location where it will be stored on file system
    /// </summary>
    /// <returns></returns>
    public string GetDirectoryWhereToSaveOnLinux()
    {
        return $"/usr/share/ublux/accounts/{IdAccount}/{FolderName}";
    }

   
}
