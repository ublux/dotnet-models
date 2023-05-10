namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToExtension : CallOutgoing, ICallToExtension
{
    #region Properties

    #region References  

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
        get => CallType.OutgoingToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
































