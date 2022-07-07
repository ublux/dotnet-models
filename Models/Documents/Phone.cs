namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     This specifies to what PBX it will be connected to
    /// </summary>
    [References(typeof(CloudServicePbx))]
    [AllowUpdate(true)]
    [IsRequired]
    public required string IdCloudServicePbx { get; set; }

    /// <summary>
    ///     Configuration phone will use
    /// </summary>
    [References(typeof(PhoneConfiguration))]
    [AllowUpdate(true)]
    public string? IdPhoneConfiguration { get; set; }

    /// <summary>
    ///     Username and password to login to web-app
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Identity))]
    public string? IdIdentity { get; set; }


    #endregion

    #region Subdocuments

    /// <summary>
    ///     Phone lines. Should never be null
    /// </summary>
    [JsonProperty(Order = 10000)]
    [AllowUpdate(false)]
    [IsRequired]
    public required List<Line> Lines { get; set; }

    #endregion

    /// <summary>
    ///     Descriptive name of phone
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public required string FriendlyName { get; set; }

    #endregion

    /// <summary>
    ///     Type of phone. If its of type web and identity (username and password) must exist in order for phone to connect.
    /// </summary>
    [IsRequired]
    [AllowUpdate(true)]
    public required PhoneType PhoneType { get; set; }
}