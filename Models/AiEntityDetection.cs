namespace Ublux.Communications.Models;

/// <summary>
///     Used for AI to detect entities such as Persons
/// </summary>
public class AiEntityDetection
{
    /// <summary>
    ///     Type of entity
    /// </summary>
    public AiEntityType EntityType { get; set; }

    /// <summary>
    ///     Index on text where entity exists. For example "hello Antonio" the entity Antonio has index 6
    /// </summary>
    public int StartPosition { get; set; }

    /// <summary>
    ///     Index on text where entity ends. For example "hello Antonio" the entity Antonio has end index 13
    /// </summary>
    public int EndPosition { get; set; }

    /// <summary>
    ///     Name of entity. This can be found by searching the text too
    /// </summary>
    public string? EntityName { get; set; }
}
