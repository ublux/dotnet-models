namespace Ublux.Communications.Models;

/// <summary>
///     Call is transferred to land-line or cell-phone
/// </summary>
public class ChildCallForwardToPSTN : ChildCall
{
    // this is the to field
    ///// <summary>
    /////     Phone number where call was transferred to
    ///// </summary>
    //public required string PhoneNumber { get; set; }

    /// <summary>
    ///     Trunk used to make call. Nullable because if trunk does not exist to call some specific country.
    /// </summary>
    [References(typeof(TrunkTermination))]
    public string? IdTrunkTermination { get; set; }

    /// <summary>
    ///     ForwardToPSTN
    /// </summary>
    [UbluxValidationRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.ForwardToPSTN;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }

    /// <summary>
    ///     Id of contact to whom call is being transfered
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(Contact))]
    public string? IdContact { get; set; }

    /// <summary>
    ///     Contact full name    
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? ContactFullName { get; set; }
}
