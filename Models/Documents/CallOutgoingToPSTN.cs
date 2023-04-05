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
    [SwaggerSchema(ReadOnly = true)]
    public override CallType CallType
    {
        get => CallType.OutgoingToPSTN;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    ///// <summary>
    /////     Is call charged as international
    ///// </summary>
    //[AllowUpdate(false)]
    //    //public bool IsInternational { get; set; }

    ///// <summary>
    /////     Country called
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IsUbluxRequired]
    //public required CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Phone number dialed in international format. Property To should contain number that was actually dialed
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string ToInternationalFormat { get; set; } = string.Empty;

    // Use seconds it took to be answered instead
    ///// <summary>
    /////     When call is answered. Note that if call is sent to voicemail this will be marked when call is answered by voicemail.
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public DateTime? DateAnswered { get; set; }
}
