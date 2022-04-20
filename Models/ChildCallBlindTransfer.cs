namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred
/// </summary>
[BsonIgnoreExtraElements]
public abstract class ChildCallBlindTransfer : ChildCall
{
    /// <summary>
    ///     Id of call that originated blind transfer
    /// </summary>
    [Required]
    public string IdCall { get; set; } = string.Empty;


    
}

