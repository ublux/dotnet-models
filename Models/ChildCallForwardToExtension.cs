namespace Ublux.Communications.Models;

/// <summary>
///     If a call is forwarded to an extension. 
///     For example if call is made to an extension dial that is configured to be forwarded to another extension if not answered this child call will be created
/// </summary>
[BsonIgnoreExtraElements]
public class ChildCallForwardToExtension : ChildCall
{
    /// <summary>
    ///     Extension being called
    /// </summary>
    [IsRequired]
    public string IdExtension { get; set; } = string.Empty;

    /// <summary>
    ///     Extension number that was called
    /// </summary>
    [IsRequired]
    public string ExtensionNumber { get; set; } = string.Empty;

    /// <summary>
    ///     Name of extension
    /// </summary>
    [IsRequired]
    public string ExtensionFriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Id of line that answered
    /// </summary>    
    public string? IdLineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that rang
    /// </summary>
    public List<string> IdsLinesThatRing
    {
        get => _IdsLinesThatRing;
        set { if (value is null) _IdsLinesThatRing.Clear(); else _IdsLinesThatRing = value; }
    }
    List<string> _IdsLinesThatRing = new();

    /// <summary>
    ///     Id of lines that did not ring
    /// </summary>
    public List<string> IdsLinesThatDidNotRing
    {
        get => _IdsLinesThatDidNotRing;
        set { if (value is null) _IdsLinesThatDidNotRing.Clear(); else _IdsLinesThatDidNotRing = value; }
    }
    List<string> _IdsLinesThatDidNotRing = new();



    /// <summary>
    ///     ForwardToExtension
    /// </summary>
    [IsRequired]
        public override ChildCallType ChildCallType { get; } = ChildCallType.ForwardToExtension;
}

