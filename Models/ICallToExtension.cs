namespace Ublux.Communications.Models;

/// <summary>
///     Shared between CallOutgoingToExtension and ChildCallForwardToExtension
/// </summary>
public interface ICallToExtension : ICall
{
    /// <summary>
    ///     Extension being called
    /// </summary>
    //[References(typeof(Extension))]
    [AllowUpdate(false)]
    //[IsUbluxRequired]
    Extension? Extension { get; set; }

    /// <summary>
    ///     Line that answered
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    Line? LineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that ring
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    List<Line> LinesThatRing { get; set; }

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    List<Line> LinesThatDidNotRing { get; set; }
}
