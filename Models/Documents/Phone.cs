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
    public string IdCloudServicePbx { get; set; } = string.Empty;

    /// <summary>
    ///     Configuration phone will use
    /// </summary>
    [References(typeof(PhoneConfiguration))]
    [AllowUpdate(true)]
    public string? IdPhoneConfiguration { get; set; }


    #endregion

    #region Subdocuments

    /// <summary>
    ///     Phone lines. Should never be null
    /// </summary>
    [JsonProperty(Order = 10000)]
    [AllowUpdate(false)]
    [IsRequired]
    public List<Line> Lines { get; set; } = new();

    #endregion

    /// <summary>
    ///     Descriptive name of phone
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string FriendlyName { get; set; } = String.Empty;


    /// <summary>
    ///     Username and password to login to web-app
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Identity))]
    public string? IdIdentityWebApp { get; set; }


    #endregion

}