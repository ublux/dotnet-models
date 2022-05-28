namespace Ublux.Communications.Models;

/// <summary>
///     Contact email address
/// </summary>
public partial class ContactEmail
{    
    // id: CE:Ac:1:email

    /// <summary>
    ///     This cannot be the id because if the email address changes we should not change the id.
    ///     Thanks to this index we can search fast on database. This index consists of: Account followed by the email address
    ///     TODO: make this an index on database. Do not make it unique only and index because we can have two contacts with the same email address
    /// </summary>
    [AllowUpdate(false)]
    public string SearchIndex
    {
        get => searchIndex;
        [Obsolete("Set via SetSearchIndex method")]
        set => searchIndex = value;
    }
    private string searchIndex = string.Empty;

    /// <summary>
    ///     Contact email address
    /// </summary>
    [AllowUpdate(true)]
    [IsRequired]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    ///     Type of email
    /// </summary>
    [AllowUpdate(true)]
    public LabelEmailType Label { get; set; }
}
