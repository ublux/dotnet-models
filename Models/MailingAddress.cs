namespace Ublux.Communications.Models;

/// <summary>
///     Mailing address
/// </summary>
public class MailingAddress
{
    /// <summary>
    ///     Recipient name
    /// </summary>
    [IsRequired]
    public required string RecipientName { get; set; }

    /// <summary>
    ///     Business Name
    /// </summary>
    public string? BusinessName { get; set; }

    /// <summary>
    ///     Street address
    /// </summary>
    [IsRequired]
    public required string StreetAddress { get; set; }

    /// <summary>
    ///     Unit number
    /// </summary>
    public string? ApparmentOrSuiteNumber { get; set; }

    /// <summary>
    ///     City
    /// </summary>
    [IsRequired]
    public required string City { get; set; }

    /// <summary>
    ///     State
    /// </summary>
    [IsRequired]
    public required string State { get; set; }

    /// <summary>
    ///     Zip code
    /// </summary>
    [IsRequired]
    public required string ZipCode { get; set; }

    /// <summary>
    ///     Country
    /// </summary>
    public required CountryIsoCode Country { get; set; } = CountryIsoCode.US;

}
