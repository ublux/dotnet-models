namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Ip address
/// </summary>
public partial class IP : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     In case there is a session the ublux user that has this ip
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(Identity))]
    [AllowUpdate(false)]
    public string? IdIdentity { get; set; }

    #endregion

    /// <summary>
    ///     False means it is white. Null means we do not know
    /// </summary>
        [AllowUpdate(false)]
    public bool? IsBlack { get; set; }

    /// <summary>
    ///     PBX or device that block this ip. We set this when uploading this ip to WS.
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    public string? IpOrigin { get; set; }

    #endregion
}

