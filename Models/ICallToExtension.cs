using System.Collections.Concurrent;

namespace Ublux.Communications.Models;

/// <summary>
///     Shared between CallOutgoingToExtension and ChildCallForwardToExtension
/// </summary>
public interface ICallToExtension : ICall
{
    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(false)]
    //[IsUbluxRequired]
    string? IdExtension { get; set; }

    /// <summary>
    ///     Phone that answered
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    string? IdPhoneThatAnswered { get; set; }

    /// <summary>
    ///     Phones that ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    ConcurrentBag<string> IdsPhonesThatRing { get; set; }

    /// <summary>
    ///     Phones that did not ring
    /// </summary>
    [References(typeof(Phone))]
    [AllowUpdate(false)]
    ConcurrentBag<string> IdsPhonesThatDidNotRing { get; set; }
}
