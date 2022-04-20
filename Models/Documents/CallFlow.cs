namespace Ublux.Communications.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Virtual receptionist
/// </summary>
public partial class CallFlow : UbluxDocument, IReferncesAccount
{
    

    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     Name of virtual receptionist
    /// </summary>
        [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;

    /// <summary>
    ///     Description of virtual receptionist
    /// </summary>
        [AllowUpdate(true)]
    public string? Description { get; set; }

    /// <summary>
    ///     XML containing the call flow rules
    /// </summary>
        [AllowUpdate(true)]
    [IsRequired]
    public string XmlTree { get; set; } = String.Empty;

    #endregion
}
