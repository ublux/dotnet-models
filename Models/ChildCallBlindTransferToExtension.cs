namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Call is blind transferred to an extension
/// </summary>
[BsonIgnoreExtraElements]
public class ChildCallBlindTransferToExtension : ChildCallBlindTransfer
{
    /// <summary>
    ///     Id of extension where it was blind transferred to
    /// </summary>
    [Required]
    public string IdExtension { get; set; } = string.Empty;

    /// <summary>
    ///     BlindTransferToExtension
    /// </summary>
    [Required]
    public override ChildCallType ChildCallType { get; } = ChildCallType.BlindTransferToExtension;
}
