#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("Id:{Id} IdAccount:{IdAccount} IdentityType:{IdentityType}")]
public partial class Identity : UbluxDocument, IReferncesAccount
{
    // id should be the username/email

    /// <summary>
    ///     If value is "0" or null it means it can use multiple accounts. For example a PBX identity can be used by multiple accounts.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IgnoreDataMember]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public virtual string IdAccount { get; set; } = String.Empty;

}

#endif