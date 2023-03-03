﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Category
/// </summary>
public partial class Tag : UbluxDocument_ReferenceAccount
{
    /// <summary>
    ///     Name of tag
    /// </summary>
    [IsUbluxRequired]
    [AllowUpdate(true)]
    public required string FriendlyName { get; set; } = string.Empty;

    /// <summary>
    ///     Color of tag
    /// </summary>
    [AllowUpdate(true)]
    public TagColor TagColor { get; set; }
}

