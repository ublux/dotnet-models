namespace Ublux.Communications.Models;

/// <summary>
///     AI Entity. Example: Date with value January 1, 2023
/// </summary>
public class AiEntity
{
    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string EntityName { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string EntityType { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double Weight { get; set; }
}
