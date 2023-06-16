namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call from PSTN to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallIncomingToExtension : CallIncoming, ICallToExtension
{
    #region Properties

    #region References

    ///// <summary>
    /////     Extension being called
    ///// </summary>
    //[References(typeof(Contact))]
    //[AllowUpdate(false)]
    //public override string? IdContact { get; set; }

    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Phone that answered
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IdPhoneThatAnswered { get; set; }

    /// <summary>
    ///     Phones that ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> IdsPhonesThatRing { get; set; } = new();

    /// <summary>
    ///     Phones that did not ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> IdsPhonesThatDidNotRing { get; set; } = new();

    #endregion

    #endregion

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public override CallType CallType
    {
        get => CallType.IncomingToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
































