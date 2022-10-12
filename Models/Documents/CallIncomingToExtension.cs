﻿namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Incoming phone call from PSTN to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallIncomingToExtension : CallIncoming, ICallToExtension
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Extension being called
    /// </summary>
    //[References(typeof(Extension))]
    [AllowUpdate(false)]
    //[IsUbluxRequired]
    public Extension? Extension { get; set; }

    /// <summary>
    ///     Line that answered
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    public Line? LineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that ring
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    public List<Line> LinesThatRing { get; set; } = new();

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    //[References(typeof(Line))]
    [AllowUpdate(false)]
    public List<Line> LinesThatDidNotRing { get; set; } = new();

    #endregion

    #endregion

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    [BsonRepresentation(BsonType.String)] // important so that it is saved on mongo
    public override CallType CallType
    {
        get => CallType.IncomingToExtension;
        //[Obsolete("set method is only used to so that field is stored on mongo DB")]
        //internal set { }
    }
}
































