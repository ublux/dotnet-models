namespace Ublux.Communications.Models;

/// <summary>
///     Speed dial
/// </summary>
public class LineKey
{
    /// <summary>
    ///     Type of line key
    /// </summary>
    [IsUbluxRequired]
    public required LineKeyType LineKeyType { get; set; }

    /// <summary>
    ///     Value of line key. Example: 9546543982
    /// </summary>
    [IsUbluxRequired]
    public required string Value { get; set; }

    /// <summary>
    ///     Display name of line key
    /// </summary>
    [IsUbluxRequired]
    public required string Label { get; set; }

    /// <summary>
    ///     Id of extension to call
    /// </summary>
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Position of line key
    /// </summary>
    public int LineKeyIndex { get; set; }
}
