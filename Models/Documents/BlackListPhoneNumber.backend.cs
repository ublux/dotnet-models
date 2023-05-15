#if UBLUX_BACKEND


namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Phone numbers that will be blocked
/// </summary>
public partial class BlackListPhoneNumber 
{
    #region SearchIndex

    /// <summary>
    ///     This cannot be the id because if the black list number changes we cannot change the id
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationRequired]
    public string SearchIndex
    {
        get => searchIndex;
#if UBLUX_Release || RELEASE
        set { searchIndex = value; }
#else
#endif
    }
    private string searchIndex = string.Empty;

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(string idAccount)
    {
        this.searchIndex = BuildSearchIndexCommon(idAccount, this.Number);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        if (string.IsNullOrEmpty(account.Id)) throw new Exception("id connot be null");
        this.searchIndex = BuildSearchIndexCommon(account.Id, this.Number);
    }

    private static string BuildSearchIndexCommon(string idAccount, string phoneNumber)
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