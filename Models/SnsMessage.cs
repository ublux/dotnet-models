namespace Ublux.Communications.Models;

/// <summary>
///     Simple notification service message
/// </summary>
public class SnsMessage
{
    /// <summary>
    ///     Id of message
    /// </summary>
    [IsUbluxRequired]
    public string Id
    {
        get;
        
        [Obsolete("Use default setter")]
        set;
    } = Guid.NewGuid().ToString();

    /// <summary>
    ///     Date when message was created in UTC
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    /// <summary>
    ///     Topic or category type
    /// </summary>
    [IsUbluxRequired]
    public required SnsTopic SnsTopic { get; set; }

    /// <summary>
    ///     Message data
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    ///     Id of account
    /// </summary>
    public string? IdAccount { get; set; }

    /// <summary>
    ///     If a phone was modified then the id of the phone
    /// </summary>
    public string? IdCollection { get; set; }

    /// <summary>
    ///     Example Accounts
    /// </summary>
    public Collections? Collection { get; set; }

    /// <summary>
    ///     Data of message. This may be json data
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    ///     If there is data then what type of data is it
    /// </summary>
    public string? DataType { get; set; }

    /// <summary>
    ///     Created by instance id
    /// </summary>
    public required string Origin { get; set; }
}
