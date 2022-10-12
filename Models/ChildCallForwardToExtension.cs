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
    // [IsUbluxRequired]
    public Extension? Extension { get; set; }

    /// <summary>
    ///     Line that answered
    /// </summary>    
    public Line? LineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that rang
    /// </summary>
    public List<Line> LinesThatRing { get; set; } = new();

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    public List<Line> LinesThatDidNotRing { get; set; } = new();

    /// <summary>
    ///     ForwardToExtension
    /// </summary>
    [IsUbluxRequired]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ChildCallType ChildCallType
    {
        get => ChildCallType.ForwardToExtension;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}

