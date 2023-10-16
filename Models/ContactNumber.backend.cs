#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

[UsedImplicitly]
public partial class ContactNumber
{
    #region SearchIndex

    /// <summary>
    ///     This cannot be the id because if the phone number changes we cannot modify the id
    ///     Thanks to this index we can search fast on database. This index consists of: Account and last 8 numbers of phone number.
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IgnoreDataMember]
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
        _searchIndex = BuildSearchIndexCommon(accountId.Id, Number);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        if (string.IsNullOrEmpty(account.Id)) throw new Exception("id cannot be null");
        _searchIndex = BuildSearchIndexCommon(account.Id, Number);
    }

    /// <summary>
    ///     Build search index. Example Ac.1-12345678
    /// </summary>
    [UsedImplicitly]
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
        foreach (var c in phoneNumber.Where(char.IsDigit).Reverse().Take(8).Reverse())
            buf[index++] = c;

        return new string(buf[..index]);
    }

    #endregion
}

#endif