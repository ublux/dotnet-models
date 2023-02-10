#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("Id:{Id} IdAccount:{IdAccount} UserType:{UserType}")]
public partial class User : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     If value is "0" or null it means it can use multiple accounts. For example a PBX user can be used by multiple accounts.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IgnoreDataMember]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public required virtual string IdAccount { get; set; } = string.Empty;
}

#endif