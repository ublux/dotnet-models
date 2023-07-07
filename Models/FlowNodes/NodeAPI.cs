namespace Ublux.Communications.Models.FlowNodes;

public partial class NodeAPI
{
    /// <summary>
    ///     Id of the request
    /// </summary>
    public required string RequestId { get; set; }

    /// <summary>
    ///     Url where to send the requst
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    ///     POST, GET, PUT, Delete
    /// </summary>
    public required string HttpMethod { get; set; } = "POST";

    /// <summary>
    ///     Body of request
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    ///     Fallback url to call in case primary url fails
    /// </summary>
    public string? UrlFallback { get; set; }

    /// <summary>
    ///     Custom headers to send. For example an Authorization header may be needed
    /// </summary>
    public List<string> Headers { get; set; } = new();

    /// <summary>
    ///     Will save response under this variable name
    /// </summary>
    public required string VariableName { get; set; }
}
