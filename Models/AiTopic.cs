namespace Ublux.Communications.Models;

/// <summary>
///     AI Topic. Example: Noise with weight .8
/// </summary>
public class AiTopic
{
    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string Topic { get; set; } = "";

    /// <summary>
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public double Weight { get; set; }
}
