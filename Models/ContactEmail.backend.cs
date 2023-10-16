#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial class ContactEmail
{
    #region Search index

    /// <summary>
    ///     This cannot be the id because if the email address changes we should not change the id.
    ///     Thanks to this index we can search fast on database. This index consists of: Account followed by the email address
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]     
    public string SearchIndex
    {
        get => _searchIndex;
#if UBLUX_Release || RELEASE
        set => _searchIndex = value;
#else
#endif
    }
    private string _searchIndex = string.Empty;

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(BuiltId accountId)
    {
        _searchIndex = BuildSearchIndexCommon(accountId.Id, Email);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        if (string.IsNullOrEmpty(account.Id)) throw new Exception("id connot be null");
        _searchIndex = BuildSearchIndexCommon(account.Id, Email);
    }

    private static string BuildSearchIndexCommon(string idAccount, string email)
    {
        if (idAccount.StartsWith(Account.DocumentPrefix) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("built id must be and id from an account");
        }

        return $"{idAccount}:{email.ToLower()}";
    }

    #endregion
}

#endif