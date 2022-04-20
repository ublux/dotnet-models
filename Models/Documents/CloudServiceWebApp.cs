﻿namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Web app where web-phone lives
/// </summary>
public partial class CloudServiceWebApp : CloudService
{
    /// <summary>
    ///     Type of cloud service
    /// </summary>
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public override CloudServiceType CloudServiceType => CloudServiceType.WA;
}
