namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument_ReferenceAccount_ReferenceTags
{
    #region Properties

    /// <summary>
    ///     Points to enum and not database!
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required EventTrigger EventTrigger { get; set; }

    /// <summary>
    ///     Url where event will be sent
    ///     TODO: place index on this field. Index is needed because when zapier deletes/unsubscribes it passes this url
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string Url { get; set; } = string.Empty;

    /// <summary>
    ///     Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    [AllowUpdate(true)]
    public List<string> Headers { get; set; } = new();

    #endregion
}
