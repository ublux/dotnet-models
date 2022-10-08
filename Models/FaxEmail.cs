namespace Ublux.Communications.Models;

/// <summary>
///     Email that we received at fax@ublux.com that will be sent via fax
/// </summary>
public class FaxEmail
{
    /// <summary>
    ///     Email id
    /// </summary>
    [IsUbluxRequired]
    public required string Id { get; set; }

    /// <summary>
    ///     Email message id
    /// </summary>
    [IsUbluxRequired]
    public required string MessageID { get; set; }

    /// <summary>
    ///     Email thread id
    /// </summary>    
    public string? ThreadId { get; set; }

    /// <summary>
    ///     Subject
    /// </summary>
    [IsUbluxRequired]
    public required string Subject { get; set; }

    /// <summary>
    ///     From
    /// </summary>
    [IsUbluxRequired]
    public required string From { get; set; }

}
