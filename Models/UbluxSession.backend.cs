#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary> 
///     Session is a logged in Identity (user). We use JWT Security tokens to store this Session.
/// </summary>
public partial class UbluxSession : IReferncesAccount
{
}

#endif