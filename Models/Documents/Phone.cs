namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     This specifies to what PBX it will be connected to
    /// </summary>
    [References(typeof(CloudServicePbx))]
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string IdCloudServicePbx { get; set; } = string.Empty;

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
    [References(typeof(User))]
    public string? IdUser { get; set; }

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Phone lines. Should never be null
    /// </summary>
    [JsonProperty(Order = 10000)]
    [AllowUpdate(true)]
    //[SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    public required List<Line> Lines { get; set; } = new();

    #endregion

    /// <summary>
    ///     Descriptive name of phone
    /// </summary>
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string FriendlyName { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     Type of phone. If its of type web and user (username and password) must exist in order for phone to connect.
    /// </summary>
    [AllowUpdate(true)]
    public required PhoneType PhoneType { get; set; }

    /// <summary>
    ///     Disable encryption in case device does not support it
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public bool DisableEncryption { get; set; }

    /// <summary>
    ///     Date when phone downloaded configuration from api.ublux.com in order to connect to Ublux
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateAutoProvision { get; set; }

    ///// <summary>
    /////     Ip address of phone when autoprovisioned
    ///// </summary>
    //[AllowUpdate(false)]
    //[SwaggerSchema(ReadOnly = true)]
    //public string? IpAutoProvision { get; set; }

    /// <summary>
    ///     Mac address of phone in case it is a phisical phone that autoprovisions with Ublux.
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? MacAddress { get; set; }

    /// <summary>
    ///     User Agent
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationStringRange(500)]
    public string? UserAgent { get; set; }

    /// <summary>
    ///     Device pin of 5 random digits used to connect phone in case extension is used by multiple phones
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationRequired]
    [UbluxValidationStringRange(50)]
    public required string Pin { get; set; } = string.Empty;

    #region MongoDB

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;        
    }

    #endregion
}