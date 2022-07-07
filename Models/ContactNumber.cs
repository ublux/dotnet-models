namespace Ublux.Communications.Models;

/// <summary>
///     Contact phone number
/// </summary>
public partial class ContactNumber
{
    /// <summary>
    ///     Phone number, Fax number, or any
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public required string Number { get; set; }

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
