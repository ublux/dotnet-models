namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public partial class Phone : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <summary>
    ///     Points to what account?
    /// </summary>
    [References(typeof(Account))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     This specifies to what PBX it will be connected to
    /// </summary>
        [References(typeof(CloudServicePbx))]
    [AllowUpdate(true)]
    [Required]    
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
    [Required]
    public List<Line> Lines
    {
        get => _Lines;
        set { if (value is null) _Lines.Clear(); else _Lines = value; }
    }
    List<Line> _Lines = new();

    #endregion

    /// <summary>
    ///     Descriptive name of phone
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public string FriendlyName { get; set; } = String.Empty;


    /// <summary>
    ///     Username and password to login to web-app
    /// </summary>
        [AllowUpdate(true)]
    [References(typeof(Identity))]
    public string? IdIdentityWebApp { get; set; }


    #endregion
}