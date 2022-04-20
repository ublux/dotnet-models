using Standart.Hash.xxHash;

namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Contact
/// </summary>
public partial class Contact : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Phone numbers of contact
    ///     Key = phone number
    ///     Value = type (example = work)
    /// </summary>
    [AllowUpdate(true)]
    public List<ContactNumber> ContactNumbers
    {
        get => _ContactNumbers;
        // ReSharper disable once ConditionIsAlwaysTrueOrFalse
        set
        {
            if (value is null) _ContactNumbers.Clear();
            else _ContactNumbers = value;
        }
    }

    List<ContactNumber> _ContactNumbers = new();

    /// <summary>
    ///     Email addresses of contact
    /// </summary>
    [AllowUpdate(true)]
    public List<ContactEmail> ContactEmails
    {
        get => _ContactEmails;
        // ReSharper disable once ConditionIsAlwaysTrueOrFalse
        set
        {
            if (value is null) _ContactEmails.Clear();
            else _ContactEmails = value;
        }
    }
    List<ContactEmail> _ContactEmails = new();

    #endregion

    /// <summary>
    ///     Contact first name
    /// </summary>
    [AllowUpdate(true)]
    public string? FirstName { get; set; }

    /// <summary>
    ///     Contact last name
    /// </summary>
    [AllowUpdate(true)]
    public string? LastName { get; set; }

    /// <summary>
    ///     Contact job tittle
    /// </summary>
    [AllowUpdate(true)]
    public string? JobTittle { get; set; }

    /// <summary>
    /// </summary>
    [AllowUpdate(true)]
    public string? Company { get; set; }

    ///// <summary>
    /////     This is the actual contact. When someone imports a contact from Gmail or outlook this are the fields that he uploads:
    /////     First Name,Middle Name,Last Name,Title,Suffix,Initials,Web Page,Gender,Birthday,Anniversary,Location,Language,Internet Free Busy,Notes,E-mail Address,E-mail 2 Address,E-mail 3 Address,Primary Phone,Home Phone,Home Phone 2,Mobile Phone,Pager,Home Fax,Home Address,Home Street,Home Street 2,Home Street 3,Home Address PO Box,Home City,Home State,Home Postal Code,Home Country,Spouse,Children,Manager's Name,Assistant's Name,Referred By,Company Main Phone,Business Phone,Business Phone 2,Business Fax,Assistant's Phone,Company,Job Title,Department,Office Location,Organizational ID Number,Profession,Account,Business Address,Business Street,Business Street 2,Business Street 3,Business Address PO Box,Business City,Business State,Business Postal Code,Business Country,Other Phone,Other Fax,Other Address,Other Street,Other Street 2,Other Street 3,Other Address PO Box,Other City,Other State
    ///// </summary>
    //public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

    // /// <summary>
    // ///     If contact was downloaded from Google then the raw contact
    // /// </summary>
    // [IgnoreDataMember]
    // [AllowUpdate(false)]
    // [HideForCreateRequest]
    // public string? RawContact { get; set; }

    /// <summary>
    ///     Used to know if contact changed or not. Contacts service is responsible (Julio) for generating this hash
    /// </summary>
    [AllowUpdate(false)]
    // [Required]
    [HideForCreateRequest]
    public string? Hash { get; set; }

    /// <summary>
    ///     Contact Notes
    /// </summary>
    [AllowUpdate(true)]
    public string? Notes { get; set; }

    /// <summary>
    ///     Customer custom data
    /// </summary>
    [AllowUpdate(true)]
    public List<Variable> Variables
    {
        get => _Variables;
        // ReSharper disable once ConditionIsAlwaysTrueOrFalse
        set
        {
            if (value is null) _Variables.Clear();
            else _Variables = value;
        }
    }
    List<Variable> _Variables = new();

    #endregion

    #region Helper methods

    /// <summary>
    ///     Get full name of contact
    /// </summary>
    public string GetFullName()
    {
        System.Text.StringBuilder sb = new(64);

        if (!string.IsNullOrEmpty(FirstName))
        {
            sb.Append(FirstName);
        }

        if (!string.IsNullOrEmpty(LastName))
        {
            if (sb.Length > 0)
                sb.Append(' ');
            sb.Append(LastName);
        }

        return sb.ToString();
    }


    /// <summary>
    ///     Compute hash of contacts. Needed so that we can sync them
    /// </summary>
    public string GetHash()
    {
        var val = string.Join(null, GetValuesNeededToHash());
        var bytes = System.Text.Encoding.UTF8.GetBytes(val);
        var hash = xxHash64.ComputeHash(bytes) >> 22;
        return ToBase92(hash);
    }

    private const string HASH_CHARACTERS
        = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ`-=[];',./~!@#$%^&*()_+{}|:<>?";

    static string ToBase92(ulong input)
    {
        ulong b = (ulong)HASH_CHARACTERS.Length;
        Span<char> result = stackalloc char[10];
        for (int i = 9; ; i--)
        {
            int reminder = (int)(input % b);
            input /= b;
            result[i] = HASH_CHARACTERS[reminder];
            if (input == 0)
                return new string(result[i..]);
        }
    }

    IEnumerable<string> GetValuesNeededToHash()
    {
        if (FirstName != null)
            yield return FirstName;
        if (LastName != null)
            yield return LastName;
        if (JobTittle != null)
            yield return JobTittle;
        if (Company != null)
            yield return Company;
        if (Notes != null)
            yield return Notes;
        foreach (var cn in ContactNumbers)
        {
            if (cn.NumberInternationalFormat is not null)
                yield return cn.NumberInternationalFormat;
        }

        foreach (var ce in ContactEmails)
        {
            if (ce.Email is not null)
                yield return ce.Email;
            //yield return ce.Label.ToString()!;
        }
    }

    #endregion
}