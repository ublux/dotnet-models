#if UBLUX_BACKEND

namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux. 
/// </summary>
public partial class StoredFile : UbluxSubDocument, IReferncesAccount
{
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

#endif