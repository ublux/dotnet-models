namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group used to call multiple parties
/// </summary>
public partial class PowerDialerGroup : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     From what phone number we will make call. 
    /// </summary>
    [References(typeof(VoipNumberPhone))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdVoipNumberPhone { get; set; }

    /// <summary>
    ///     Override caller id?
    /// </summary>
    [References(typeof(CallerIdMask))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public string? IdCallerIdMask { get; set; }

    ///// <summary>
    /////     What IVR to execute
    ///// </summary>
    //[References(typeof(CallFlowLogic))]
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //public string? IdCallFlowLogic { get; set; }

    ///// <summary>
    /////     If on mode simple what extensions will ring to take phone calls
    ///// </summary>
    //[References(typeof(Extension))]
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //public string? IdExtension { get; set; }

    /// <summary>
    ///     Agents that will be using power dialer
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(true)]
    public List<string> IdPhonesAgents { get; set; } = new();

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Subdocument
    /// </summary>
    [AllowUpdate(true)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required List<PowerDialerContact> PowerDialerContacts { get; set; } = new();

    #endregion

    /// <summary>
    ///     Friendly name of power dialer group
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Description of power dialer group
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationStringRange(2000)]
    public string? Description { get; set; }

    /// <summary>
    ///     Status of power dialer
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [HideForCreateRequest]
    public PowerDialerGroupStatus PowerDialerGroupStatus  // added for convenience
    {
        get { return (PowerDialerGroupStatus)Interlocked.CompareExchange(ref _powerDialerGroupStatus, 0, 0); }
        set { Interlocked.Exchange(ref _powerDialerGroupStatus, (int)value); }
    }
    int _powerDialerGroupStatus = (int)PowerDialerGroupStatus.Pending;

    /// <summary>
    ///     If there is an error in general with the group and NOT with a power dialer item contact.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    // [HideForCreateRequest]
    [UbluxValidationStringRange(2000)]
    public string? ErrorMessage { get; set; } 

    ///// <summary>
    /////     Prevent executing if it exceeds this date range
    ///// </summary>
    //public UbluxTime MaxTimeLimit { get; set; }

    ///// <summary>
    /////     Used by pbx to know what is the current item that is executing. Also by web service to let front know what index is being executed.
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[HideForCreateRequest]
    //public int PowerDialerExecutingRecordIndex { get; set; }

    ///// <summary>
    /////     If there are 5 agents using the power dialer then there can 5 five concurrent calls.
    /////     When power dialer was first created only one call at a time existed. When that call ended the next call was made.
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[UbluxValidationRequired]
    //public int NumberOfConcurrentCalls { get; set; }

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
    }

    #endregion
}
