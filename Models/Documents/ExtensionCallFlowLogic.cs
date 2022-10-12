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
    [IsUbluxRequired]
    public required string IdCallFlowLogic { get; set; }

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
    [IsUbluxRequired]
    [HideForCreateRequest]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override ExtensionType ExtensionType
    {
        get => ExtensionType.CallFlowLogic;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
