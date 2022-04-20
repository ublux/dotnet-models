namespace Ublux.Communications.Models;

/// <summary>
///     Email that we received at fax@ublux.com that will be sent via fax
/// </summary>
public class FaxEmail
{
    /// <summary>
    ///     Email id
    /// </summary>
    [IsRequired]
    public string Id { get; set; } = string.Empty;
    /// <summary>
    ///     Email message id
    /// </summary>
    [IsRequired]
    public string MessageID { get; set; } = string.Empty;
    /// <summary>
    ///     Email thread id
    /// </summary>    
    public string? ThreadId { get; set; }
    /// <summary>
    ///     Subject
    /// </summary>
    [IsRequired]
    public string Subject { get; set; } = string.Empty;
    /// <summary>
    ///     From
    /// </summary>
    [IsRequired]
    public string From { get; set; } = string.Empty;
}
