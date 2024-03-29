﻿namespace Ublux.Communications.Models;

/// <summary>
///     Send email notification if call takes to long to be answered. This is used for extension queue
/// </summary>
public class SendEmailNotificationIfItTakesToLongToBeAnswered
{
    /// <summary>
    ///     Send email notification if call takes more than this amount of time to be answered
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public required int TimeInSeconds { get; set; }

    /// <summary>
    ///     Email addresses where to send notifications in case call is not answered.
    /// </summary>
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    [References(typeof(Email))]
    public required List<string> IdsEmails { get; set; } = [];
}
