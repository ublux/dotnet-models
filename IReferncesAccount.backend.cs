#if UBLUX_BACKEND


namespace Ublux.Communications.Models;

/// <summary>
///     Model points to an account. Most models should have this.
/// </summary>
public interface IReferencesAccount
{
    /// <summary>
    ///     It is nullable because there are cases where it makes no sense to point to an account. 
    ///     For example a CloudService user will point to no account
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public string IdAccount { get; set; }
}

#endif
