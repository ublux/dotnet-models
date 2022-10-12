#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
[DebuggerDisplay("Id:{Id} IdAccount:{IdAccount} IdentityType:{IdentityType}")]
public partial class Identity : UbluxDocument, IReferncesAccount
{
    /// <summary>
    ///     If value is "0" or null it means it can use multiple accounts. For example a PBX identity can be used by multiple accounts.
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IgnoreDataMember]
    [HideForCreateRequest]
    // virtual because of unit tests so that it can mock this object
    public required virtual string IdAccount { get; set; }

    /// <summary>
    ///     What type of user is this? Is this a PBX? WA?
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    [HideForCreateRequest] // remember to add this on admin service!
    // virtual because of unit tests so that it can mock this object
    public required IdentityType IdentityType { get; set; }
}

#endif