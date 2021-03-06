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
    public required string Id { get; set; }

    /// <summary>
    ///     Email message id
    /// </summary>
    [IsRequired]
    public required string MessageID { get; set; }

    /// <summary>
    ///     Email thread id
    /// </summary>    
    public string? ThreadId { get; set; }

    /// <summary>
    ///     Subject
    /// </summary>
    [IsRequired]
    public required string Subject { get; set; }

    /// <summary>
    ///     From
    /// </summary>
    [IsRequired]
    public required string From { get; set; }

}
