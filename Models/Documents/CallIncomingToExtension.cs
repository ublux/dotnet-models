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
    ///     Line that answered
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IdLineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> IdsLinesThatRing { get; set; } = new();

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public List<string> IdsLinesThatDidNotRing { get; set; } = new();

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
































