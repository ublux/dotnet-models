﻿namespace Ublux.Communications.Models;

/// <summary>
///     Speed dial
/// </summary>
public class SpeedDial
{
    /// <summary>
    ///     Type of line key
    /// </summary>
    [UbluxValidationRequired]
    public required SpeedDialType SpeedDialType { get; set; }

    /// <summary>
    ///     Display name of line key
    /// </summary>
    [UbluxValidationRequired]
    public required string Label { get; set; }

    /// <summary>
    ///     Value of line key. Example: 9546543982
    ///     Only requried if SpeedDialType is SpeedDial
    /// </summary>
    [UbluxValidationRequired]
    public string? Value { get; set; }

    /// <summary>
    ///     Id of extension to call
    /// </summary>
    [References(typeof(Extension))]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Position of line key. This is importante because maybe a user may want to skip some positions
    /// </summary>
    public int SpeedDialIndex { get; set; }
}
