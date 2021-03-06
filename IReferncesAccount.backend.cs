#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     Model points to an account. Most models should have this.
/// </summary>
public interface IReferncesAccount
{
    /// <summary>
    ///     The convention Name underscore denotes that there is a reference
    /// </summary>
    [References(typeof(Account))]
    [HideForCreateRequest]
    public string IdAccount { get; set; }
}

#endif
