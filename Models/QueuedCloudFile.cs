#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Queued cloud file pending to be uploaded
/// </summary>
public class QueuedCloudFile : IUbluxDocumentId, IDisposable
{
    /// <summary>
    ///     Id of queued email. This will be the file name if stored on a file system
    /// </summary>    
    public string Id { get => CloudFile.Id; init { } }

    /// <summary>
    ///     Thanks to this enum we know from what email to send the email
    /// </summary>
    public required CloudFile CloudFile { get; set; }

    /// <summary>
    ///     Get stream content of file
    /// </summary>
    public required string PathToFile { get; set; }

    /// <summary>
    ///     Once succesffully uploaded delete file?
    /// </summary>
    public required bool DeleteFileWhenUploaded { get; set; }

    /// <summary>
    ///     Dispose
    /// </summary>
    public void Dispose()
    {
        if (DeleteFileWhenUploaded)
            File.Delete(PathToFile);
    }
}

#endif