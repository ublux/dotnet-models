namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument, IReferncesAccount
{
    #region Properties

    #region References

    /// <inheritdoc />
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [References(typeof(Account))]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     VOIP number that sent/received SMS message
    /// </summary>
        [AllowUpdate(false)]
    [References(typeof(VoipNumber))]
    [IsRequired]
    public string IdVoipNumber { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     Contact
    /// </summary>
        [AllowUpdate(false)]
    public Contact? Contact { get; set; }

    #endregion

    /// <summary>
    ///     True if SMS was received false otherwise
    /// </summary>
        [AllowUpdate(false)]
    public bool IsIncoming { get; set; }

    /// <summary>
    ///     SMS message
    /// </summary>
        [AllowUpdate(false)]
    [IsRequired]
    public string Body { get; set; } = string.Empty;

    //    // [AllowUpdate(false)]
    //public int? ZipCode { get; set; }

    /// <summary>
    ///     If a SMS body is to large, it will be sent in multiple chunks/segments
    /// </summary>
        [AllowUpdate(false)]
    [IsRequired]
    public int NumSegments { get; set; }

    /// <summary>
    ///     Status of SMS
    /// </summary>
        [AllowUpdate(false)]
    public string? Status { get; set; }

    //    // [AllowUpdate(false)]
    //public decimal? Price { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaUrl { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaSid { get; set; }

    //    // [AllowUpdate(false)]
    //public string MediaName { get; set; }

    //    // [AllowUpdate(false)]
    //public int MediaType { get; set; }

    /// <summary>
    ///     Number that sent SMS
    /// </summary>
        [AllowUpdate(false)]
    [IsRequired]
    public string FromInternationalFormat { get; set; } = string.Empty;

    /// <summary>
    ///     Number to whom SMS was sent to 
    /// </summary>
        [AllowUpdate(false)]
    [IsRequired]
    public string ToInternationalFormat { get; set; } = string.Empty;

    #endregion

}
