#if UBLUX_BACKEND


namespace Ublux.Communications.Models.SubDocuments;

/// <summary>
///     Outgoing fax
/// </summary>
public partial class FaxOutgoing : UbluxSubDocument
{
    /// <summary>
    ///     This is a subdocument. Id of parent
    /// </summary>
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [References(typeof(FaxOutgoingGroup))]
    [UbluxValidationIsRequired]
    public required string IdFaxOutgoingGroup { get; set; }

    /// <summary>
    ///     Email attachment that was converted to fax
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    [UbluxValidationIsRequired]
    public required EmailAttachment EmailAttachment { get; set; }

    /// <summary>
    ///     True when done sending fax
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IgnoreDataMember]
    public bool IsComplete { get; set; }

    /// <summary>
    ///     Determine if fax contains an error
    /// </summary>
    public bool ContainsError()
    {
        return !string.IsNullOrEmpty(ErrorMessage);
    }
}

#endif