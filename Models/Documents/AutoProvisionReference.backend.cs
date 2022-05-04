#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Id is the mac address of a phone. It should point to an ip phone
/// </summary>
public partial class AutoProvisionReference : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of phone that this mac is associated with
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(Phone))]
    [IsRequired]
    public string IdPhone { get; set; } = String.Empty;

    /// <summary>
    ///     When phone is connected to case27 and it wants to connect to a new phone. It will do so but when phone requests cfg file
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(Phone))]
    public string? IdPhoneToExchangeWith { get; set; }

    #endregion

    /// <summary>
    ///     When phone calls *54 we will set this to true. We need phone to stay connected so that we can send auto-provision
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public bool RequestedDisconnect { get; set; }

    #endregion
}

#endif