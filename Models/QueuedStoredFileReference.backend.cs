﻿#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Queued cloud file pending to be uploaded. 
///     Thanks to this we can upload file from disk to the cloud with an ID.
/// </summary>
public class QueuedStoredFileReference : IUbluxDocumentId
{

#if UBLUX_Release || RELEASE

    // This constructor is needed by mongo. 
    /// <summary /> 
    public QueuedStoredFileReference()
    {
    }

#endif

    /// <summary>
    ///     Constructor
    /// </summary>
    public QueuedStoredFileReference(string pathToFileOnDisk, StoredFileReference sfr, bool deleteDileWhenDisposing = true)
    {
        this.PathToFile = pathToFileOnDisk;
        this.StoredFileReference = sfr;
        this.DeleteFileWhenUploaded = deleteDileWhenDisposing;
    }

    /// <summary>
    ///     Id of queued email. This will be the file name if stored on a file system
    /// </summary>    
    public string Id
    {
#if UBLUX_Release || RELEASE
        set; get;
#else
        get => StoredFileReference.Id;
#endif
    }

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
    public bool MoveFile(string directoryNewLocation)
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
                var dest = Path.Combine(directoryNewLocation, fileName);

                File.Move(PathToFile, dest);

                return true;
            }

            return false;
        }
        catch
        {
            return false;
        }

    }

    /// <summary>
    ///     Once succesffully uploaded delete file?
    /// </summary>
    public bool DeleteFileWhenUploaded
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#endif
    }
}

#endif