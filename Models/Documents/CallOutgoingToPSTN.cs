namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to cell phone or land line
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToPSTN : CallOutgoing
{
    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override CallType CallType
    {
        get => CallType.OutgoingToPSTN;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }

    ///// <summary>
    /////     Is call charged as international
    ///// </summary>
    //[AllowUpdate(false)]
    //    //public bool IsInternational { get; set; }

    /// <summary>
    ///     Country called
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Phone number dialed in international format. Property To should contain number that was actually dialed
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string ToInternationalFormat { get; set; }
}
