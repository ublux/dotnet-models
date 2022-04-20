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
    [IsRequired]
    public string IdNumber { get; set; } = String.Empty;

    /// <summary>
    ///     Example Passport or CifNif
    /// </summary>
    [IsRequired]
    public string IdType { get; set; } = String.Empty;

    /// <summary>
    ///     This province should be obtained from AirNetworkProvinces table
    /// </summary>
    [IsRequired]
    public string Province { get; set; } = String.Empty;

    /// <summary>
    ///     Id of air networks province
    /// </summary>
    [References(typeof(AirNetworksProvince))]
    [IsRequired]
    public string IdAirNetworksProvince { get; set; } = String.Empty;

    /// <summary>
    ///     Population
    /// </summary>
    [IsRequired]
    public string Population { get; set; } = String.Empty;

    #endregion
}
