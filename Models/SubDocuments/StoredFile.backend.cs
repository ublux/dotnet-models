#if UBLUX_BACKEND

using System.Security.Cryptography;

namespace Ublux.Communications.Models.SubDocuments;

// Previously called SaveOnAwsBucket

/// <summary>
///     Represents a stored file in ublux such as a recording or audio.
/// </summary>
public partial class StoredFile : UbluxSubDocument, IReferncesAccount
{
    /// <summary>
    ///     Get id of cloud file
    /// </summary>
    public string GetIdStoredFileReference()
    {
        return StoredFileReference.BuildId(this).Id;
    }
    /// <summary>
    ///     Static implementation
    /// </summary>
    public static string GetIdStoredFileReference(string idStoredFile)
    {
        return StoredFileReference.BuildId(idStoredFile).Id;
    }

    /// <summary>
    ///     Id of account it references. If its an internal account use Account.GetIdTbdCase27()
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string IdAccount { get; set; } = "";

    /// <summary>
    ///     Example incoming-faxes
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required StorageFolderName FolderName { get; set; }

    /// <summary>
    ///     Server that stored this file so that other servers can download it. Example W for work. Thus it can be downloaded from w.ublux.com    
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(50)]
    public required string InstanceId { get; set; } = string.Empty;

    /// <summary>
    ///     Helper to get hash
    /// </summary>
    public static string ComputeMd5Hash(string filePath)
    {
        // compute md5 hash
        try
        {
            using MD5 md5 = MD5.Create();
            using var stream = File.OpenRead(filePath);
            var hash = md5.ComputeHash(stream);
            string hex = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            return hex;
        }
        catch
        {
            return "";
        }
    }
}

#endif