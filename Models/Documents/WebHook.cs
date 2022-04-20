namespace Ublux.Communications.Domain.Models.Documents;


/// <summary>
///     Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public partial class WebHook : UbluxDocument
{
    #region References

    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [Required]
    [HideForCreateRequest]
    public string IdAccount { get; set; } = String.Empty;

    #endregion

    /// <summary>
    ///     Points to enum and not database!
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public WebHookEvent WebHookEvent { get; set; }

    /// <summary>
    ///     Url where event will be sent
    /// </summary>
        [AllowUpdate(true)]
    [Required]
    public string Url { get; set; } = String.Empty;

    /// <summary>
    ///     Custom headers to inject on request. Example: x-token:1234,user:eduardo
    /// </summary>
        [AllowUpdate(true)]
    public List<string> Headers
    {
        get => _Headers;
        set { if (value is null) _Headers.Clear(); else _Headers = value; }
    }
    List<string> _Headers = new();
}
