#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Queued cloud file pending to be uploaded. 
///     Thanks to this we can upload file from disk to the cloud with an ID.
/// </summary>
public class QueuedStoredFileReference : IUbluxDocumentId
{
#if UBLUX_Release || RELEASE
#pragma warning disable CS8618

    // This constructor is needed by mongo. 
    /// <summary /> 
    public QueuedStoredFileReference()
    {
    }

#pragma warning restore CS8618
#endif

    /// <summary>
    ///     Constructor
    /// </summary>
    public QueuedStoredFileReference(string pathToFileOnDisk, StoredFileReference sfr, bool deleteDileWhenDisposing = true)
    {
        PathToFile = pathToFileOnDisk;
        StoredFileReference = sfr;
        DeleteFileWhenUploaded = deleteDileWhenDisposing;
        id = sfr.id;
    }

    /// <summary>
    ///     Id of queued email. This will be the file name if stored on a file system
    /// </summary>    
    public string Id
    {
        get => id;
#if UBLUX_Release || RELEASE
        set { id = value; }
#endif
    }

    private string id;

    /// <summary>
    ///     Thanks to this enum we know from what email to send the email
    /// </summary>
    public StoredFileReference StoredFileReference
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#endif
    }

    /// <summary>
    ///     Get stream content of file
    /// </summary>
    public string PathToFile
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#else
        private set;
#endif
    }

    /// <summary>
    ///     Move file to a new location. 
    ///     Maybe because we had an error uploading it and we will movie it from a temp dir to a permanent location.
    /// </summary>
    public bool MoveFile(string directoryNewLocation, out string? newLocation)
    {
        try
        {
            if (File.Exists(PathToFile))
            {
                if (Directory.Exists(directoryNewLocation) == false)
                {
                    Directory.CreateDirectory(directoryNewLocation);
                }

                var fileName = Path.GetFileName(PathToFile);
                newLocation = Path.Combine(directoryNewLocation, fileName);

                File.Move(PathToFile, newLocation);

                return true;
            }

            newLocation = null;
            return false;
        }
        catch
        {
            newLocation = null;
            return false;
        }
    }

    /// <summary>
    ///     Once successfully uploaded delete file?
    /// </summary>
    public bool DeleteFileWhenUploaded
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#endif
    }

    // /// <summary>
    // ///     null = not backup
    // ///     false = backup failed
    // ///     true = backup worked
    // /// </summary>
    // public bool? IsBackup { get; set; }

    /// <summary>
    ///     Fires when this queued file is backed up successfully to the cloud AND to database
    /// </summary>
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public Action<QueuedStoredFileReference>? OnBackupSuccessful { get; set; }

    /// <summary>
    ///     Fires if there is an error uploading the file
    /// </summary>
    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public Action<QueuedStoredFileReference>? OnBackupFailed { get; set; }
    
    private long backupFlag;

    /// <summary>
    ///     Returns backup flag
    /// </summary>
    /// <returns>
    ///     0   = not backed up
    ///     1   = backed up successful
    ///     -1  = error backing up
    /// </returns>
    public long GetBackupFlag()
    {
        return Interlocked.Read(ref backupFlag);
    }

    /// <summary>
    ///     0   = not backed up
    ///     1   = backed up successful
    ///     -1  = error backing up
    /// </summary>
    public void SetBackupFlag(long v)
    {
        Interlocked.Exchange(ref backupFlag, v);
    }
}

#endif