﻿using JsonSubTypes;

namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Trunk used to receive phone calls
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(TrunkOriginationType))]
[JsonSubtypes.KnownSubType(typeof(TrunkOriginationForward), nameof(Enum.Format))]
[JsonSubtypes.KnownSubType(typeof(TrunkOriginationRegister), nameof(TrunkOriginationType.Register))]
[BsonKnownTypes(
    typeof(TrunkOriginationForward),
    typeof(TrunkOriginationRegister)
)]
[BsonIgnoreExtraElements]
public abstract class TrunkOrigination : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     Id Provider
    /// </summary>
    [IgnoreDataMember]
    [References(typeof(VoipProvider))]
    [AllowUpdate(false)]
    [Required]
    public string IdVoipProvider { get; set; } = string.Empty;

    /// <summary>
    ///     Used by what PBX?
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [Required]
    public string IdCloudServicePbx { get; set; } = string.Empty;

    /// <summary>
    ///     Backup pbx
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(CloudServicePbx))]
    [Required]
    public string IdCloudServicePbxFailover { get; set; } = string.Empty;

    /// <summary>
    ///     Faxes and numbers used by this trunk
    /// </summary>
    [References(typeof(VoipNumber))]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public List<string> IdsVoipNumbers
    {
        get => _IdsVoipNumbers;
        set { if (value is null) _IdsVoipNumbers.Clear(); else _IdsVoipNumbers = value; }
    }
    List<string> _IdsVoipNumbers = new();

    #endregion

    #endregion

    /// <summary>
    ///     Type of trunk origination
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [Required]
    public abstract TrunkOriginationType TrunkOriginationType { get; }

    ///// <summary>
    /////     When a pbx goes offline or is unhealthy we will move this trunk origination to failover region
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool? IsMovedToFailoverRegion { get; set; }

    /// <summary>
    ///     Provider ID
    ///     Example: TKcc9b6e6d8f7394a4e896a5e6b7880110 for twilio
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string SID { get; set; } = string.Empty;

    ///// <summary>
    /////     DIDs associated with this trunk
    ///// </summary>
    //public List<string> Id_DIDs { get; set; }

    /// <summary>
    ///     Friendly name
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [Required]
    public string FriendlyName { get; set; } = string.Empty;

    ///// <summary>
    /////     Is connection secure?
    ///// </summary>
    //[IgnoreDataMember]
    //[AllowUpdate(false)]
    //public bool IsSecure { get; set; }

    
}
