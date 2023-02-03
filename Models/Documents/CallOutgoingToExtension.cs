namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Call made to an extension
/// </summary>
[BsonIgnoreExtraElements]
public partial class CallOutgoingToExtension : CallOutgoing, ICallToExtension
{
    #region Properties

    #region Subdocuments

    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(false)]
    // [IsUbluxRequired]
    public string? IdExtension { get; set; }

    /// <summary>
    ///     Line that answered
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    public string? IdLineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    public List<string> IdsLinesThatRing { get; set; } = new();

    /// <summary>
    ///     Lines that did not ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
    public List<string> IdsLinesThatDidNotRing { get; set; } = new();

    #endregion

    #endregion

    ///// <summary>
    /////     Extension number that was called
    ///// </summary>
    //[AllowUpdate(false)]
    //[IsUbluxRequired]
    //public required string ExtensionNumber { get; set; }

    ///// <summary>
    /////     Name of extension
    ///// </summary>
    //[AllowUpdate(false)]
    //[IsUbluxRequired]
    //public required string ExtensionFriendlyName { get; set; }

    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
    public override CallType CallType
    {
        get => CallType.OutgoingToExtension;
        [Obsolete("set method is only used to so that field is stored on mongo DB")]
        internal set { }
    }
}
































