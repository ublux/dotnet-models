namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument
{
    #region Properties    

    /// <summary>
    ///     Points to enum and not database!
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public WebHookEvent WebHookEvent { get; set; }

    /// <summary>
    ///     Url where event will be sent
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string Url { get; set; } = String.Empty;

    /// <summary>
    ///     Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    [AllowUpdate(true)]
    public List<string> Headers { get; set; } = new();

    #endregion
}
