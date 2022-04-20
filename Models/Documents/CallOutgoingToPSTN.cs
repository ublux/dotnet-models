namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Call made to cell phone or land line
/// </summary>
public partial class CallOutgoingToPSTN : CallOutgoing
{
    /// <summary>
    ///     Trunk termination used to make phone call
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(TrunkTermination))]
    [AllowUpdate(false)]
    public string? IdTrunkTermination { get; set; }


    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
        public override CallType CallType => CallType.OutgoingToPSTN;

    ///// <summary>
    /////     Is call charged as international
    ///// </summary>
    //[AllowUpdate(false)]
    //    //public bool IsInternational { get; set; }

    /// <summary>
    ///     Country called
    /// </summary>
    [AllowUpdate(false)]
        public CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Phone number dialed in international format 
    /// </summary>
    [AllowUpdate(false)]
        public string? ToInternationalFormat { get; set; }

    ///// <inheritdoc/>
    //public override I To()
    //{
    //    throw new NotImplementedException();
    //}

  
}
































