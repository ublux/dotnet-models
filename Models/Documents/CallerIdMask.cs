namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class CallerIdMask : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    /// <summary>
    ///     The phone that will be used as caller id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     Name of this caller id mask
    /// </summary>
    [AllowUpdate(true)]    
    [IsUbluxRequired]
    public required string FriendlyName { get; set; }    

    #endregion
}