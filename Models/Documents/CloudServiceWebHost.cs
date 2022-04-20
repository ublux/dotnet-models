﻿namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Server where ublux website lives
/// </summary>
public partial class CloudServiceWebHost : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.WH;
}
