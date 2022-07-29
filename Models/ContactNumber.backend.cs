#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial class ContactNumber
{
    #region SearchIndex

    /// <summary>
    ///     This cannot be the id because if the phone number changes we cannot modify the id
    ///     Thanks to this index we can search fast on database. This index consists of: Account and last 8 numbers of phone number.
    ///     TODO: make this an index on database. Do not make it unique only and index because we can have two contacts with the same phone number
    /// </summary>
    [AllowUpdate(false)]
    public string SearchIndex
    {
        get => searchIndex;
        [Obsolete("Set via SetSearchIndex method")]
        set => searchIndex = value;
    }
    private string searchIndex = string.Empty;

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(BuiltId accountId)
    {
        this.searchIndex = BuildSearchIndexCommon(accountId.Id, this.Number);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        if (string.IsNullOrEmpty(account.Id)) throw new Exception("id connot be null");
        this.searchIndex = BuildSearchIndexCommon(account.Id, this.Number);
    }

    /// <summary>
    ///     Build search index. Example Ac.1-12345678
    /// </summary>
    public static string BuildSearchIndexCommon(string idAccount, string phoneNumber)
    {
        if (idAccount.StartsWith(Account.DocumentPrefix) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("built id must be and id from an account");
        }

        if (phoneNumber is null)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("There must be a phone number in order to build search index");
        }

        Span<char> buf = stackalloc char[16];
        //var buf = new char[16];
        var index = 0;

        // append id of account
        foreach (var c in idAccount)
            buf[index++] = c;

        // append separator
        buf[index++] = '-';

        // append last 8 digits
        foreach (var c in phoneNumber.Where(x => char.IsDigit(x)).Reverse().Take(8).Reverse())
            buf[index++] = c;

        return new string(buf[..index]);
    }

    #endregion
}

#endif