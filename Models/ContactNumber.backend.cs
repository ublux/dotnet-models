#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

public partial class ContactNumber
{
    #region Setter

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(BuiltId builtId)
    {
        this.searchIndex = BuildSearchIndexCommon(builtId.Id, this.Number);
    }

    /// <summary>
    ///     Set value of search index
    /// </summary>
    public void SetSearchIndex(Account account)
    {
        this.searchIndex = BuildSearchIndexCommon(account.Id, this.Number);
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

    private static string BuildSearchIndexCommon(string idAccount, string phoneNumber)
    {
        if (idAccount.StartsWith(Account.DocumentPrefix) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("built id must be and id from an account");
        }

        if(phoneNumber is null)
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
        buf[index++] = ':';

        // append last 8 digits
        foreach (var c in phoneNumber.Where(x => char.IsDigit(x)).Reverse().Take(8).Reverse())
            buf[index++] = c;

        return new string(buf[..index]);
    }
}

#endif