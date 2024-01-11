using System.Collections.Concurrent;

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
    ///     Phone that answered
    /// </summary>    
    [References(typeof(Phone))]
    public string? IdPhoneThatAnswered { get; set; }

    /// <summary>
    ///     Phones that ring
    /// </summary>
    [References(typeof(Phone))]
    public ConcurrentBag<string> IdsPhonesThatRing { get; set; } = [];

    /// <summary>
    ///     Phones that did not ring
    /// </summary>
    [References(typeof(Phone))]
    public ConcurrentBag<string> IdsPhonesThatDidNotRing { get; set; } = [];

    /// <summary>
    ///     ForwardToExtension
    /// </summary>
    [UbluxValidationRequired]
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.ForwardToExtension;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}

