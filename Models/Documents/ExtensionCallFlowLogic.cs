﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Executes a custom IVR when calling this extension
/// </summary>
public partial class ExtensionCallFlowLogic : Extension
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of call flow to execute
    /// </summary>
    [References(typeof(CallFlowLogic))]
    [AllowUpdate(true)]
    [UbluxValidationRequired]
    public required string IdCallFlowLogic { get; set; } = string.Empty;

    #endregion

    /// <summary>
    ///     Optional label to jump to on the call flow?
    /// </summary>
    [AllowUpdate(true)]
    public string? CallFlowLabel { get; set; }

    /// <summary>
    ///     Execute call flow with this timezone. 
    ///     This is important if you have the IfBusinessHours node in the call flow for example.
    /// </summary>
    [AllowUpdate(true)]
    public string? TimeZone { get; set; }

    #endregion

    /// <summary>
    ///     Type of extension
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [HideForCreateRequest]
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.CallFlowLogic;
#if UBLUX_Release || RELEASE
        set { }
#else
#endif
    }
}
