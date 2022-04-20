namespace Ublux.Communications.Models;

/// <summary>
///     Speed dial
/// </summary>
public class LineKey
{
    /// <summary>
    ///     Type of line key
    /// </summary>
    [Required]
    public LineKeyType LineKeyType { get; set; }

    /// <summary>
    ///     Value of line key. Example: 9546543982
    /// </summary>
    [Required]
    public string Value { get; set; } = string.Empty;

    /// <summary>
    ///     Display name of line key
    /// </summary>
    [Required]
    public string Label { get; set; } = string.Empty;

    /// <summary>
    ///     Id of extension to call
    /// </summary>
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Position of line key
    /// </summary>
    public int LineIndex { get; set; }
}
