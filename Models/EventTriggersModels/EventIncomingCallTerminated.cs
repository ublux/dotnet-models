namespace Ublux.Communications.Models.EventTriggersModels;

public partial class EventIncomingCallTerminated
{
    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string From { get; set; }

    /// <summary>
    ///     From phone number
    /// </summary>
    [AllowUpdate(false)]
    public required string To { get; set; }

    /// <summary>
    ///     Date when call started
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateStart { get; set; }

    /// <summary>
    ///     Date when call was ended
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateEnded { get; set; }
}
