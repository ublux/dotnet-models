#if UBLUX_BACKEND
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
    [UbluxValidationIsRequired]
    public required string IdNumber { get; set; } 

    /// <summary>
    ///     Example Passport or CifNif
    /// </summary>
    [UbluxValidationIsRequired]
    public required string IdType { get; set; } 

    /// <summary>
    ///     This province should be obtained from AirNetworkProvinces table
    /// </summary>
    [UbluxValidationIsRequired]
    public required string Province { get; set; } 

    /// <summary>
    ///     Id of air networks province
    /// </summary>
    [References(typeof(AirNetworksProvince))]
    [UbluxValidationIsRequired]
    public required string IdAirNetworksProvince { get; set; } 

    /// <summary>
    ///     Population
    /// </summary>
    [UbluxValidationIsRequired]
    public required string Population { get; set; } 

    #endregion
}
#endif