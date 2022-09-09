namespace Ublux.Communications.Enums;

/// <summary>
///     Type of call
/// </summary>
public enum CallType
{
    /// <summary>
    ///     Incoming phone call that executed an IVR
    /// </summary>
    IncomingToCallFlowLogic,

    /// <summary>
    ///     Incoming phone call that called an extension
    /// </summary>
    IncomingToExtension,

    /// <summary>
    ///     Outgoing phone call to an extension
    /// </summary>
    OutgoingToExtension,

    /// <summary>
    ///     Outgoing phone call to PSTN
    /// </summary>
    OutgoingToPSTN,

    /// <summary>
    ///     Voicemail phone call by dialing *1
    /// </summary>
    FeatureVoicemail,
}
