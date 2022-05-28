namespace Ublux.Communications.Models;

/// <summary>
///     Contact phone number
/// </summary>
public partial class ContactNumber
{
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
    ///     Phone number, Fax number, or any
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    ///     Phone number normalized in national format. This is needed so that searches are faster.
    ///     db.GlobalContacts.createIndex({"PhoneNumbers.PhoneNumberNormalized":1})
    /// </summary>
    [AllowUpdate(false)] // update Number will change this
    public string? NumberInternationalFormat { get; set; }

    /// <summary>
    ///     Example Main, Work, Fax, Mobile
    /// </summary>
    [AllowUpdate(true)]
    public LabelNumber Label { get; set; }
}
