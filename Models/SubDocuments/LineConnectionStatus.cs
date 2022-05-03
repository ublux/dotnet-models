namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Status of phone line
/// </summary>
public class LineConnectionStatus : UbluxSubDocument
{

    ///// <inheritdoc />
    //public override string SubDocumentPrefix() => "SubLCS";


    ///// <inheritdoc />
    //public override void SetId() => id = $"{UCore.InstanceId}:{SubDocumentPrefix()}:{DateTime.UtcNow.ToUnixEpoch()}:{Interlocked.Increment(ref DomainGlobals.IdGenerationCounter)}";

    /// <summary>
    ///     Public ip address of the connection
    /// </summary>
    [AllowUpdate(false)]
    public string? IpWAN { get; set; }

    /// <summary>
    ///     Public port
    /// </summary>
    [AllowUpdate(false)]
    public int PortWAN { get; set; }

    /// <summary>
    ///     Private ip address of the connection
    /// </summary>
    [AllowUpdate(false)]
    public string? IpLAN { get; set; }

    /// <summary>
    ///     Private port
    /// </summary>
    [AllowUpdate(false)]
    public int PortLAN { get; set; }

    /// <summary>
    ///     User agent of phone connecting
    /// </summary>
    [AllowUpdate(false)]
    public string? UserAgent { get; set; }

    /// <summary>
    ///     Null means we do not know
    /// </summary>
    [AllowUpdate(false)]
    public bool? IsConnected { get; set; }

    /// <summary>
    ///     Date when line was last connected
    /// </summary>
    [AllowUpdate(false)]
    public DateTime? DateConnected { get; set; }

    // Have we sent sip notify? we send a sip notify if a phone does not send a packet for to long. 
    // Sending a sip notify will increase the probably of phone replying so we do not mark it as disconnected when in fact it is connected.
    private bool _sentSipNotify;
    /// <summary>
    ///     Set value of _sentSipNotify
    /// </summary>
    public void SetSentSipNofity(bool v) => _sentSipNotify = v;
    /// <summary>
    ///     Get value of _sentSipNotify
    /// </summary>
    public bool GetSentSipNofity() => _sentSipNotify;

}
