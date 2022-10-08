namespace Ublux.Communications.Models.Documents; 

/// <summary>
///     SMS message
/// </summary>
public partial class SMS : UbluxDocument
{
    #region Properties

    #region References

    /// <summary>
    ///     VOIP number that sent/received SMS message
    /// </summary>
    [AllowUpdate(false)]
    [References(typeof(VoipNumber))]
    [IsUbluxRequired]
    public required string IdVoipNumber { get; set; }

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
    [IsUbluxRequired]
    public required string Body { get; set; }

    //    // [AllowUpdate(false)]
    //public int? ZipCode { get; set; }

    /// <summary>
    ///     If a SMS body is to large, it will be sent in multiple chunks/segments
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required int NumSegments { get; set; }

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
    [IsUbluxRequired]
    public required string From { get; set; }

    /// <summary>
    ///     Number to whom SMS was sent to 
    /// </summary>
    [AllowUpdate(false)]
    [IsUbluxRequired]
    public required string To { get; set; }

    #endregion
}
