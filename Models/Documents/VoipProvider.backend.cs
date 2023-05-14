#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     VOIP provider. Some providers have an API that enable us to automate things.
///     Examples of voip providers are Twilio, Marcatel, Airnetworks etc...
/// </summary>
public partial class VoipProvider : UbluxDocument
{
    /// <summary>
    ///     Id on provider. We may need this to authenticate
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required string ProviderAccountId { get; set; } = string.Empty;

    /// <summary>
    ///     The account id of the owner account. If this is the owner account then this will be the same as the id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? ProviderOwnerAccountId {
        get { try { /*custom-get-code*/ _lock.EnterReadLock(); return _ProviderOwnerAccountId; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _ProviderOwnerAccountId = value; /*custom-set-code*/ } finally { _lock.ExitWriteLock(); }}
    }
    private string? _ProviderOwnerAccountId;

    /// <summary>
    ///     Twilio calls this authority token
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? ProviderAccessToken {
        get { try { /*custom-get-code*/ _lock.EnterReadLock(); return _ProviderAccessToken; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _ProviderAccessToken = value; /*custom-set-code*/ } finally { _lock.ExitWriteLock(); }}
    }
    private string? _ProviderAccessToken;

    /// <summary>
    ///     Ublux partner
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required UbluxPartner UbluxPartner { get; set; } 

    /// <summary>
    ///     Friendly name of this provider
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Used mostly for sub-accounts. A sub account in twilio can be suspended, closed or active 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public string? Status {
        get { try { /*custom-get-code*/ _lock.EnterReadLock(); return _Status; } finally { _lock.ExitReadLock(); } }
        set { try { _lock.EnterWriteLock(); _Status = value; /*custom-set-code*/ } finally { _lock.ExitWriteLock(); }}
    }
    private string? _Status;

    /// <summary>
    ///     Country of this provider
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required CountryIsoCode Country { get; set; }

    /// <summary>
    ///     Company of this provider for example Twilio
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required VoipCompany VoipCompany { get; set; }

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;        
    }

    #endregion
}

#endif