#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial class ContactEmail
{
    #region Setters

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(BuiltId builtId)
    {
        this.searchIndex = BuildSearchIndexCommon(builtId.Id, this.Email);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        this.searchIndex = BuildSearchIndexCommon(account.Id, this.Email);
    }

    #endregion

    #region Static helper method to build search index

    /// <summary>
    ///     Build serach index
    /// </summary>
    public static string BuildSearchIndex(Account account, string phoneNumber)
    {
        return BuildSearchIndexCommon(account.Id, phoneNumber);
    }

    /// <summary>
    ///     Build serach index
    /// </summary>
    public static string BuildSearchIndex(BuiltId idAccount, string phoneNumber)
    {
        return BuildSearchIndexCommon(idAccount.Id, phoneNumber);
    }

    #endregion

    private static string BuildSearchIndexCommon(string idAccount, string email)
    {
        if (idAccount.StartsWith(Account.DocumentPrefix) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("built id must be and id from an account");
        }

        return $"{idAccount}:{(email ?? "").ToLower()}";
    }
}

#endif