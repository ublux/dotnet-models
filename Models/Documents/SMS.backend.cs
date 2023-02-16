#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument, IReferncesAccount
{
    #region References

    /// <inheritdoc />
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public required string? IdAccount { get; set; }

    #endregion
}

#endif