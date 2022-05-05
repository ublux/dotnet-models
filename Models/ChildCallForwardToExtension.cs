namespace Ublux.Communications.Models;

/// <summary>
///     If a call is forwarded to an extension. 
///     For example if call is made to an extension dial that is configured to be forwarded to another extension if not answered this child call will be created
/// </summary>
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
    public List<string> IdsLinesThatRing { get; set; } = new();

    /// <summary>
    ///     Id of lines that did not ring
    /// </summary>
    public List<string> IdsLinesThatDidNotRing { get; set; } = new();

    /// <summary>
    ///     ForwardToExtension
    /// </summary>
    [IsRequired]
    public override ChildCallType ChildCallType { get; } = ChildCallType.ForwardToExtension;
}

