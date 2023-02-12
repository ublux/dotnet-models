#if UBLUX_BACKEND

using Swashbuckle.AspNetCore.Annotations;

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class CallerIdMask : UbluxDocument, IReferncesAccount
{
    #region References

    /// <summary>
    ///     Account that uses this caller id mask
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     Code that user must enter to verify caller id
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string RandomVerificationCode { get; set; } = string.Empty;

}

#endif