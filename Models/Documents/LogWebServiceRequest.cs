namespace Ublux.Communications.Models.Documents;

/// <summary>
///     All request sent to ublux will be stored.
/// </summary>
public partial class LogWebServiceRequest : UbluxDocument
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Authenticated client
    /// </summary>
    [AllowUpdate(false)]
    public UbluxSession? UbluxSession { get; set; }

    #endregion

    /// <summary>
    ///     Number of concurrent requests when this log message was created. 
    ///     For example if 5 reques are made at the same time this count may be equal to 5.
    /// </summary>
    [AllowUpdate(false)]
    public int ConcurrentRequests { get; set; }

    /// <summary>
    ///     This is used to charge customers.
    ///     
    ///     Ever time a user consumes the api it will have a cost. 
    ///     At the end of each month we will charge the customer based on this sum.
    /// </summary>
    [AllowUpdate(false)]
    public uint Charge { get; set; }

    /// <summary>
    ///     Keep track of the sum of charges of each identity. 
    ///     For example the identity a.namnum@gmail.com may have a current charge of 1282732
    ///     This is not needed but will save us to have to execute a SUM query to find this charge
    /// </summary>
    // todo add index on mongo db. this key index should be combined with id_Id_Identity!
    [AllowUpdate(false)]
    [Obsolete(
        "Marked as obsolete only to remember that it should never be set only by service that keeps track of sum")]
    public ulong IdentityChargeSum { get; set; }

    /// <summary>
    ///     This is used to determine if an ip address is blocked or not.
    /// </summary>
    [AllowUpdate(false)]
    public uint Penalty { get; set; }

    /// <summary>
    ///     Is it a GET,POST,DELETE or PATCH request?
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string HttpMethod { get; set; } = string.Empty;

    /// <summary>
    ///     User agent
    /// </summary>
    [AllowUpdate(false)]
    public string? UserAgent { get; set; }

    /// <summary>
    ///     Ip address where request came from
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Ip { get; set; } = string.Empty;

    /// <summary>
    ///     Request url without query string
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string RequestUrl { get; set; } = string.Empty;

    /// <summary>
    ///     Save query string?
    /// </summary>
    [AllowUpdate(false)]
    [BsonIgnore] // do not store on DB
    public bool SaveQueryString { get; set; } = true;

    /// <summary>
    ///     Parameters send on query string. A post may also contain a query string!
    /// </summary>
    [AllowUpdate(false)]
    public string? QueryString { get; set; }

    /// <summary>
    ///     Post data sent by user. GET methods will have this empty.
    /// </summary>
    [AllowUpdate(false)]
    public string? RequestBody { get; set; }

    /// <summary>
    ///     We only store response body on POST,DELETE and PATCH commands
    /// </summary>
    [AllowUpdate(false)]
    public string? ResponseBody { get; set; }

    /// <summary>
    ///     Response status code
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public HttpResponseStatusCode HttpResponseStatusCode { get; set; }

    /// <summary>
    ///     Response time in milliseconds. 
    ///     This is the duration of the request
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public int ResponseTime { get; set; }

    #endregion
}