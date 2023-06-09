namespace Ublux.Communications.Enums;

/// <summary>
///     
/// </summary>
public enum FlowNodeType
{
    /// <summary> Convert text to audio and play that message </summary>
    Say,

    /// <summary> Play an audio </summary>
    Play,

    /// <summary></summary>
    IfDigits,
    /// <summary></summary>
    Digits,
    /// <summary></summary>
    AnyDigits,


    /// <summary></summary>
    IfTime,
    /// <summary>From 10 AM to 6 PM for example. </summary>
    Time,
    /// <summary></summary>
    AnyTime,


    /// <summary></summary>
    IfWeekDay,
    /// <summary>From Monday to Thursday for example. </summary>
    WeekDays,
    /// <summary></summary>
    AnyWeekDay,



    /// <summary> Call an extension </summary>
    Extension,

    /// <summary></summary>
    DynamicExtension,

    /// <summary> If a line is offline </summary>
    IfLineOffline,
    /// <summary> Line is online </summary>
    LineOnline,
    /// <summary> Line is offline </summary>
    LineOffline,

    /// <summary> Call phone number </summary>
    Call,

    /// <summary> Wait some time </summary>
    Pause,

    /// <summary> Go to a specific bookmark </summary>
    GoTo,
    /// <summary> Use GoTo node to go to this bookmark </summary>
    Bookmark,

    /// <summary> Comment to describe an action </summary>
    Comment,


    /// <summary> Call an api to execute custom logic</summary>
    API,

    /// <summary> Execute response from API </summary>
    CallBackAPI,

    /// <summary> Hangup </summary>
    Hangup
}
