namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to cell phone or land line
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToPowerDialer : CallOutgoingToPSTN
{
    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override CallType CallType
    {
        get => CallType.PowerDialer;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Belongs to what power dialer gorup
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(PowerDialerGroup))]
    [UbluxValidationNotRequired]
    public required string IdPowerDialerGroup { get; set; }

    /// <summary>
    ///     Belongs to what power dialer contact
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(PowerDialerGroup))]
    [UbluxValidationNotRequired]
    public required string IdPowerDialerContact { get; set; }
}
