namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Ip address
/// </summary>
public partial class IP : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     False means it is white. Null means we do not know
    /// </summary>
    [AllowUpdate(false)]
    public bool? IsBlack { get; set; }

    #endregion
}

