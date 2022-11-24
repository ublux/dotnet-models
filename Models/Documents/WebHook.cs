namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument, IReferencesTags
{
    #region Properties    

    #region References

    /// <summary>
    ///     Ids of tags
    /// </summary>
    [AllowUpdate(true)]
    [References(typeof(Tag))]
    public List<string> Tags { get; set; } = new();

    #endregion

    /// <summary>
    ///     Points to enum and not database!
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required EventTrigger EventTrigger { get; set; }

    /// <summary>
    ///     Url where event will be sent
    /// </summary>
    [AllowUpdate(true)]
    [IsUbluxRequired]
    public required string Url { get; set; }

    /// <summary>
    ///     Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    [AllowUpdate(true)]
    public List<string> Headers { get; set; } = new();

    #endregion
}
