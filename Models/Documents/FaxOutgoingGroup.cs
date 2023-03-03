namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Group of faxes sent as a group via email
/// </summary>
public partial class FaxOutgoingGroup : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    #region References

    /// <summary>
    ///     Id of Fax VoipNumber (virtual number) that sent the fax
    /// </summary>    
    [References(typeof(VoipNumberFax))]
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string IdVoipNumberFax { get; set; } = string.Empty;

    #endregion

    #region Subdocuments

    /// <summary>
    ///     There must be at least one fax attachment
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public List<FaxOutgoing> FaxesOutgoing { get; set; } = new();

    ///// <summary>
    /////     Email that was sent to fax@ublux.com
    ///// </summary>
    //[AllowUpdate(false)] 
    //[SwaggerSchema(ReadOnly = true)] 
    //[IsUbluxRequired]
    //public required FaxEmail FaxEmail { get; set; }

    #endregion

    /// <summary>
    ///     Phone number where fax is sent
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    [IsUbluxRequired]
    public required string From { get; set; } = string.Empty;

    /// <summary>
    ///     If fax is sent successfully then send confirmation to this emails
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [IsUbluxRequired]
    [References(typeof(Email))]
    public required List<string> IdsEmailsSendConfirmation { get; set; } = new();

    /// <summary>
    ///     True if there is an error
    /// </summary>
    [AllowUpdate(false)] 
    [SwaggerSchema(ReadOnly = true)] 
    public bool ContainsError { get; set; }

    #endregion
}
