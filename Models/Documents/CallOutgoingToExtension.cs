namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToExtension : CallOutgoing, ICallToExtension
{
    #region Properties

    #region Subdocuments

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

    ///// <summary>
    /////     Extension number that was called
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IsUbluxRequired]
    //public required string ExtensionNumber { get; set; } = string.Empty;

    ///// <summary>
    /////     Name of extension
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //[IsUbluxRequired]
    //public required string ExtensionFriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public override CallType CallType
    {
        get => CallType.OutgoingToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
































