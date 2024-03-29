﻿namespace Ublux.Communications.Models;

/// <summary>
///     Contact phone number
/// </summary>
public partial class ContactNumber
{
    /// <summary>
    ///     Phone number, Fax number, or any
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    [UbluxValidationStringRange(1, 20)]
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
    public LabelNumberType Label { get; set; }
}
