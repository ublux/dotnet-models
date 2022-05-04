namespace Ublux.Communications.Models.Documents;

/// <summary>
///     When a customer purchases a Phone Number from AirNetworks Provider from Spain he needs to feel the province and population info
/// </summary>
public partial class AirNetworksProvince : UbluxDocument
{
    #region Properties

    /// <summary>
    ///     Example: ALAVA
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public string Name { get; set; } = String.Empty;

    /// <summary>
    ///     List of "poblaciones". Example: ABENGIBRE, ABUZADERAS, AGRA....
    /// </summary>
    [AllowUpdate(false)]
    [IsRequired]
    public List<string> Populations
    {
        get => _Populations;
        set { if (value is null) _Populations.Clear(); else _Populations = value; }
    }
    List<string> _Populations = new();

    #endregion
}
