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
    [IsRequired]
    public required CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Phone number dialed in international format. Property To should contain number that was actually dialed
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public required string ToInternationalFormat { get; set; }
}
