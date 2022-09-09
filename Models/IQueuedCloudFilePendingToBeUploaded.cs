namespace Ublux.Communications.Models
{
    public interface IQueuedCloudFilePendingToBeUploaded
    {
        CloudFile CloudFile { get; set; }
        string Id { get; }
    }
}