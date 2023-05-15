namespace Ublux.Communications.Models;

/// <summary>
///     Call is blind transferred
/// </summary>
public abstract class ChildCallBlindTransfer : ChildCall
{
    /// <summary>
    ///     Id of call that originated blind transfer
    /// </summary>
    [UbluxValidationRequired]
    [References(typeof(Call))]
    public required string IdCall { get; set; } 
}
