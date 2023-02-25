#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial class ContactEmail
{
    #region Search index



    /// <summary>
    ///     This cannot be the id because if the email address changes we should not change the id.
    ///     Thanks to this index we can search fast on database. This index consists of: Account followed by the email address
    ///     TODO: make this an index on database. Do not make it unique only and index because we can have two contacts with the same email address
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)]     
    public string SearchIndex
    {
        get => searchIndex;
#if UBLUX_Release || RELEASE
        set => searchIndex = value;
#else
#endif
    }
    private string searchIndex = string.Empty;



    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(BuiltId accountId)
    {
        this.searchIndex = BuildSearchIndexCommon(accountId.Id, this.Email);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        if (string.IsNullOrEmpty(account.Id)) throw new Exception("id connot be null");
        this.searchIndex = BuildSearchIndexCommon(account.Id, this.Email);
    }

    private static string BuildSearchIndexCommon(string idAccount, string email)
    {
        if (idAccount.StartsWith(Account.DocumentPrefix) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("built id must be and id from an account");
        }

        return $"{idAccount}:{(email ?? "").ToLower()}";
    }

    #endregion
}

#endif