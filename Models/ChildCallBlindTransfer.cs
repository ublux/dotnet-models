namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred
/// </summary>
public abstract class ChildCallBlindTransfer : ChildCall
{
    /// <summary>
    ///     Id of call that originated blind transfer
    /// </summary>
    [IsRequired]
    public required string IdCall { get; set; } 
}
