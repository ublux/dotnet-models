namespace Ublux.Communications.Domain.Models;

/// <summary>
///     Mailing address
/// </summary>
public class MailingAddress
{
    /// <summary>
    ///     Recipient name
    /// </summary>
    public string RecipientName { get; set; } = string.Empty;

    /// <summary>
    ///     Business Name
    /// </summary>
    public string? BusinessName { get; set; }

    /// <summary>
    ///     Street address
    /// </summary>
    public string StreetAddress { get; set; } = string.Empty;

    /// <summary>
    ///     Unit number
    /// </summary>
    public string? ApparmentOrSuiteNumber { get; set; }

    /// <summary>
    ///     City
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    ///     State
    /// </summary>
    public string State { get; set; } = string.Empty;

    /// <summary>
    ///     Zip code
    /// </summary>
    public string ZipCode { get; set; } = string.Empty;

    /// <summary>
    ///     Country
    /// </summary>
    public CountryIsoCode Country { get; set; } = CountryIsoCode.US;

}
