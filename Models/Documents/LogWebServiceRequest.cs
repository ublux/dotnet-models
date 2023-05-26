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
    [SwaggerSchema(ReadOnly = true)]
    public UbluxSession? UbluxSession { get; set; }

    #endregion

    /// <summary>
    ///     Number of concurrent requests when this log message was created. 
    ///     For example if 5 reques are made at the same time this count may be equal to 5.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int ConcurrentRequests { get; set; }

    /// <summary>
    ///     This is used to charge customers.
    ///     
    ///     Ever time a user consumes the api it will have a cost. 
    ///     At the end of each month we will charge the customer based on this sum.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public uint Charge { get; set; }

    ///// <summary>
    /////     Keep track of the sum of charges of each user. 
    /////     For example the user a.namnum@gmail.com may have a current charge of 1282732
    /////     This is not needed but will save us to have to execute a SUM query to find this charge
    ///// </summary>
    //// todo add index on mongo db. this key index should be combined with id_Id_User!
    //[AllowUpdate(false)]
    //[Obsolete(
    //    "Marked as obsolete only to remember that it should never be set only by service that keeps track of sum")]
    //public ulong UserChargeSum { get; set; }

    /// <summary>
    ///     Current penalty of ip address when this request was made
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public long CurrentPenalty { get; set; }

    /// <summary>
    ///     Total penalty of ip address when this request was made
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public long TotalPenalty { get; set; }

    /// <summary>
    ///     Is it a GET,POST,DELETE or PATCH request?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string HttpMethod { get; set; } = string.Empty;

    /// <summary>
    ///     User agent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(500)]
    public string? UserAgent { get; set; }

    /// <summary>
    ///     Ip address where request came from
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required string Ip { get; set; } = string.Empty;

    /// <summary>
    ///     Request url without query string
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(2000)]
    public required string RequestUrl { get; set; } = string.Empty;

    /// <summary>
    ///     Save query string?
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    //[BsonIgnore] // gives problesm with unit test. Just include it
    public bool SaveQueryString { get; set; } = true;

    /// <summary>
    ///     Parameters send on query string. A post may also contain a query string!
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(2000)]
    public string? QueryString { get; set; }

    /// <summary>
    ///     Post data sent by user. GET methods will have this empty.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(4000)]
    public string? RequestBody { get; set; }

    ///// <summary>
    /////     We only store response body on POST,DELETE and PATCH commands
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[UbluxValidationStringRange(4000)]
    //public string? ResponseBody { get; set; }

    /// <summary>
    ///     Response status code
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required HttpResponseStatusCode HttpResponseStatusCode { get; set; }

    /// <summary>
    ///     Response time in milliseconds. 
    ///     This is the duration of the request
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [UbluxValidationRequired]
    public int ResponseTime { get; set; }

    #endregion

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;

        // enable searching fast by ip address
        yield return new MongoDbIndex(collection, nameof(this.Ip))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by id of account
        yield return new MongoDbIndex(collection, nameof(this.UbluxSession), nameof(UbluxSession.IdAccount))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));

        // enable searching fast by request url
        yield return new MongoDbIndex(collection, nameof(this.RequestUrl))
            // Append DateCreated at the end so that items are returned by dateCreated
            .Add(nameof(DateCreated));
    }

    #endregion
}