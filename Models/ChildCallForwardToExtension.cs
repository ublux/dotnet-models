namespace Ublux.Communications.Models;

/// <summary>
///     If a call is forwarded to an extension. 
///     For example if call is made to an extension dial that is configured to be forwarded to another extension if not answered this child call will be created
/// </summary>
public class ChildCallForwardToExtension : ChildCall, ICallToExtension
{
    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    // [IsUbluxRequired]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Line that answered
    /// </summary>    
    [References(typeof(Line))]
    public string? IdLineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that rang
    /// </summary>
    [References(typeof(Line))]
    public List<string> IdsLinesThatRing { get; set; } = new();

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    [References(typeof(Line))]
    public List<string> IdsLinesThatDidNotRing { get; set; } = new();

    /// <summary>
    ///     ForwardToExtension
    /// </summary>
    [IsUbluxRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.ForwardToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}

