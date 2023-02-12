using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public required string Name { get; set; }

    /// <summary>
    ///     List of "poblaciones". Example: ABENGIBRE, ABUZADERAS, AGRA....
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    public List<string> Populations { get; set; } = new();

    #endregion
}
