namespace Ublux.Communications.Models;

/// <summary>
///     Normalized phone number
/// </summary>
public class NormalizedPhoneNumber
{
    /// <summary>
    ///     Phone number in national format. Example +13051234567
    /// </summary>
    public string? NationalFormat { get; set; }

    /// <summary>
    ///     Is it a mobile phone number? Null if unknown
    /// </summary>
    public bool? IsMobile { get; set; }

    /// <summary>
    ///     Country of phone number. Null if unknown
    /// </summary>
    public CountryIsoCode? CountryIsoCode { get; set; }
}
