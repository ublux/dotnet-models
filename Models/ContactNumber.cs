namespace Ublux.Communications.Models;

/// <summary>
///     Contact phone number
/// </summary>
public class ContactNumber
{
    ///// <summary>
    /////     Id account followed by last 8 digits of phone number. Example: 2-12345678
    /////     todo: make sure you add an index on mongo db by this field
    ///// </summary>
    //public string? Id { get; set; }    

    /// <summary>
    ///     Phone number, Fax number, or any
    /// </summary>
    [Required]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Phone number normalized in national format. This is needed so that searches are faster.
    ///     db.GlobalContacts.createIndex({"PhoneNumbers.PhoneNumberNormalized":1})
    /// </summary>
    public string? NumberInternationalFormat { get; set; }

    ///// <summary>
    /////     Type of number. Work, main
    ///// </summary>
    //public string? NumberType { get; set; }

    /// <summary>
    ///     Example Main, Work, Fax, Mobile
    /// </summary>
    public LabelNumber Label { get; set; }

    /// <summary>
    ///     Thanks to this ID we can search for a phone number regardless if two accounts have the same number
    ///     1-46543985
    /// </summary>
    public string Generate_IdAccountAndLast8Digits(string id_account)
    {
        return Generate_IdAccountAndLast8Digits(id_account, Number);
    }
    /// <summary>
    ///     Thanks to this ID we can search for a phone number regardless if two accounts have the same number
    ///     1-46543985
    /// </summary>
    public static string Generate_IdAccountAndLast8Digits(string idAccount, string? number)
    {
        if (number == null)
            return $"{idAccount}-";

        System.Text.StringBuilder sb = new(16);
        sb.Append(idAccount);
        sb.Append('-');
        foreach (var c in number.Where(x => char.IsDigit(x)).Reverse().Take(8).Reverse())
            sb.Append(c);
        return sb.ToString();
    }
}
