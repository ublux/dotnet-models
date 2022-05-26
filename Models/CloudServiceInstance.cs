namespace Ublux.Communications.Models;

/// <summary>
///     Instance that is currently running. Every instance should have a different id
///     Could service instance. Before we used to have this id on a file. Now it is part of IoC container in order to make unit tests better
/// </summary>
public class CloudServiceInstance
{
    /// <summary>
    ///     Example US-T
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    ///     Type of Cloud service
    /// </summary>
    public CloudServiceType CloudServiceType { get; set; }

    /// <summary>
    ///     Generate a random Instance. Used for unit tests 
    /// </summary>
    public static CloudServiceInstance GenerateRandom(CloudServiceType type)
    {
        return new CloudServiceInstance()
        {
            Id = (type + "-" + Guid.NewGuid().ToString()[..4]).ToUpper(),
            CloudServiceType = type
        };
    }


    /// <summary>
    ///     If we cannot read or store IdGlobal to disk
    /// </summary>
    public bool Flaged_IdGlobal_DiskError = false;

    /// <summary>
    ///     If we cannot read or write IdStreamModified to disk
    /// </summary>
    public bool Flaged_IdStreamModified_DiskError = false;

    /// <summary>
    ///     If we cannot read or write IdStreamDeleted to disk
    /// </summary>
    public bool Flaged_IdStreamDeleted_DiskError = false;

}
