namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to cell phone or land line
/// </summary>
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
    public CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Phone number dialed in international format 
    /// </summary>
    [AllowUpdate(false)]
    public string? ToInternationalFormat { get; set; }
}
