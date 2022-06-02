﻿#if UBLUX_BACKEND

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
    [References(typeof(FaxOutgoingGroup))]
    [IsRequired]
    public string IdFaxOutgoingGroup { get; set; } = string.Empty;
    
    /// <summary>
    ///     Email attachment that was converted to fax
    /// </summary>
    [AllowUpdate(false)]
    [IgnoreDataMember]
    [IsRequired]
    public EmailAttachment EmailAttachment { get; set; } = new EmailAttachment();

    /// <summary>
    ///     True when done sending fax
    /// </summary>
    [AllowUpdate(false)]
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