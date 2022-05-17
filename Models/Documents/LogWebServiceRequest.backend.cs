#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     All request sent to ublux will be stored.
/// </summary>
[DebuggerDisplay("RequestUrl={RequestUrl}")]
public partial class LogWebServiceRequest : UbluxDocument
{
    /// <summary>
    ///     Save request body? If true RequestBody should be set
    /// </summary>
    [AllowUpdate(false)]
    [BsonIgnore] // do not store on DB
    [IgnoreDataMember]
    public bool SaveRequestBody { get; set; }

    /// <summary>
    ///     Save response body? If true ResponseBody should be set
    /// </summary>
    [AllowUpdate(false)]
    [BsonIgnore] // do not store on DB
    [IgnoreDataMember]
    public bool SaveResponseBody { get; set; }

}

#endif