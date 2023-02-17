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
    [SwaggerSchema(ReadOnly = true)]
    //[BsonIgnore] // gives problesm with unit test. Just include it
    [IgnoreDataMember]
    public bool SaveRequestBody { get; set; }

    /// <summary>
    ///     Save response body? If true ResponseBody should be set
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    //[BsonIgnore] // gives problesm with unit test. Just include it
    [IgnoreDataMember]
    public bool SaveResponseBody { get; set; }
}

#endif