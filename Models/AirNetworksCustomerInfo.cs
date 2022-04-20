namespace Ublux.Communications.Models;

/// <summary>
///     Provider AirNetworks requests this information for every customer
/// </summary>
public class AirNetworksCustomerInfo
{
    #region Required for AirNetworks customers

    /// <summary>
    ///     The passport number or driver's license number
    /// </summary>
    [Required]
    public string IdNumber { get; set; } = String.Empty;

    /// <summary>
    ///     Example Passport or CifNif
    /// </summary>
    [Required]
    public string IdType { get; set; } = String.Empty;

    /// <summary>
    ///     This province should be obtained from AirNetworkProvinces table
    /// </summary>
    [Required]
    public string Province { get; set; } = String.Empty;

    /// <summary>
    ///     Id of air networks province
    /// </summary>
    [References(typeof(AirNetworksProvince))]
    [Required]
    public string IdAirNetworksProvince { get; set; } = String.Empty;

    /// <summary>
    ///     Population
    /// </summary>
    [Required]
    public string Population { get; set; } = String.Empty;

    #endregion
}
